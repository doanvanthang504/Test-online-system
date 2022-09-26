using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.DTO;
using ThangDV29_MiniProject_WebAPI.DTO.ModelsView.StudentModelView;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Table;
using ThangDV29_MiniProject_WebAPI.ModelsView.StudentGetExamModelView;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;

namespace ThangDV29_MiniProject_WebAPI.Repository.MyRepository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IApplicationDBContext _dbContext;

        public StudentRepository(IApplicationDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<IEnumerable<StudentListStatusModelView>> ExamResultStatus(Guid studentID)
        {
            var examList = await _dbContext.StudentExams.ToListAsync();
            if (examList == null) return null;

            var result = examList.FindAll(e => e.StudentID == studentID);
            if (result == null) return null;

            return result.Select(e => new StudentListStatusModelView(e));
        }

        public async Task<HistoryExamStudentModelView> GetHistoryExam(Guid studentID)
        {
            var studen = await _dbContext.Accounts.Include(e => e.StudentExams)
                                                  .FirstOrDefaultAsync(e => e.ID == studentID);

            if (studen == null) return null;
            var historyExamStudent = new HistoryExamStudentModelView()
            {
                NameStudent = studen.FullName,
                Email = studen.Email,
                BirthDay = studen.BirthDay.ToString(),
            };
            var historyExamList = studen.StudentExams;
            
            var historyExamMVList = new List<HistoryExamModelView>();
            foreach (var items in historyExamList)
            {
                var examList = await _dbContext.HistoryExams.Include(e => e.Exams)
                                                            .Include(e => e.Exams.ExamQuestions)
                                                            .Where(e => e.AccountID == items.StudentID)
                                                            .ToListAsync();

                var historyExam = new HistoryExamModelView()
                {
                    ExamID = items.ExamID,
                    NameExam = items.Exams.NameExam,
                    DateExam = items.Exams.DateExam.ToString()
                };
                historyExamMVList.Add(historyExam);

                historyExamStudent.HistoryExams = historyExamMVList;
            }
            return historyExamStudent;

        }

        public async Task<StudentGetExamModelView> StudentGetExam(Guid ExamID)
        {
            var exam = await _dbContext.Exams.Include(e => e.ExamQuestions)
                                             .FirstOrDefaultAsync(e => e.ID == ExamID);
            if (exam != null)
            {
                var studentGetExamModel = new StudentGetExamModelView()
                {
                    ID = exam.ID,
                    NameExam = exam.NameExam,
                    DateExam = exam.DateExam,
                    TimeExam = exam.TimeExam,
                };

                var examQuestionsList = exam.ExamQuestions;
                var examWithQuestionList = new List<ExamWithQuestionsModelView>();
                foreach (var itemsExam in examQuestionsList)
                {
                    var examList = await _dbContext.ExamQuestion
                                                    .Include(e => e.Questions)
                                                    .Include(e => e.Questions.QuestionAnswers)
                                                    .FirstOrDefaultAsync(e => e.ExamID == itemsExam.ExamID);
                    var examQuestion = new ExamWithQuestionsModelView()
                    {
                        QuestionID = examList.QuestionID,
                        NameQuestion = examList.Questions.NameQuestion,
                        ImageQuestion = examList.Questions.ImageQuestion,
                    };
                    examWithQuestionList.Add(examQuestion);
                }

                var examWithQuestionNewList = new List<ExamWithQuestionsModelView>();
                foreach (var itemsQuestion in examWithQuestionList)
                {
                    var questionList = await _dbContext.QuestionAnswers
                                                       .Include(e => e.Answers)
                                                       .Where(e => e.QuestionID == itemsQuestion.QuestionID)
                                                       .ToListAsync();

                    var questionAndAnserList = new List<QuestionAndAnswerModelView>();
                    foreach (var itemsAnswer in questionList)
                    {
                        var answerList = new QuestionAndAnswerModelView()
                        {
                            AnswerID = itemsAnswer.AnswerID,
                            DescriptionAnswer = itemsAnswer.Answers.DescriptionAnswer,
                            ImageAnswer = itemsAnswer.Answers.ImageAnswer,
                        };
                        questionAndAnserList.Add(answerList);
                    }

                    itemsQuestion.QuestionAndAnswers = questionAndAnserList;
                    examWithQuestionNewList.Add(itemsQuestion);
                }
                studentGetExamModel.ExamHaveManyQuestion = examWithQuestionNewList;
                return studentGetExamModel;
            }
            return null;
        }

        public async Task<ScoreStudent> SubmitExamStudent(Guid examID, Guid studentID, Dictionary<Guid, List<Guid>> answers)
        {
            var questionList = await _dbContext.ExamQuestion
                                    .Where(e => e.ExamID == examID)
                                    .Select(e => e.QuestionID)
                                    .ToListAsync();
            if (questionList == null) return null;

            var scorePerQuestion = 100 / questionList.Count();

            var scoreOfStudent = 0d;
            foreach (var questionId in questionList)
            {
                var isHaveAnswered = answers.TryGetValue(questionId, out List<Guid> answerOfStudent);
                if (!isHaveAnswered)
                {
                    continue;
                }
                var isCorrectAnswer = await _dbContext.QuestionAnswers
                                                 .Where(e => e.QuestionID == questionId && e.ResultAnswer == true)
                                                 .Select(e => e.ResultAnswer)
                                                 .ToListAsync();

                foreach (var answer in answerOfStudent)
                {
                    var isValidAnswer = await _dbContext.Answers.AnyAsync(e => e.ID == answer);
                    if (!isValidAnswer)
                    {
                        return new ScoreStudent()
                        {
                            IsSucceed = false,
                        };
                    }
                    _dbContext.HistoryExams.Add(new HistoryExam
                    {
                        ExamID = examID,
                        QuestionID = questionId,
                        AnswerID = answer,
                        AccountID = studentID
                    });
                }

                if (isCorrectAnswer != null)
                {
                    scoreOfStudent += scorePerQuestion;
                }
            }
            _dbContext.StudentExams.Add(new StudentExam
            {
                ExamID = examID,
                StudentID = studentID,
                Score = scoreOfStudent
            });
            return ScoreStudent.CreateSuccess(scoreOfStudent);
        }
    }
}
