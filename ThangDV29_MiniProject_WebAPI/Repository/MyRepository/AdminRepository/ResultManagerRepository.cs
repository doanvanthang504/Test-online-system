using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Table;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;

namespace ThangDV29_MiniProject_WebAPI.Repository.MyRepository
{
    public class ResultManagerRepository : IResultManagerRepository
    {

        private readonly IApplicationDBContext _dbcontext;

        public ResultManagerRepository(IApplicationDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<StudentExamResultModelView>> getListByFunctAsync(Expression<Func<StudentExam, bool>> func)
        {
            var studentExams = await _dbcontext.StudentExams.Include(p => p.Exams)
                                                            .Include(p => p.Students)
                                                            .Where(func).ToListAsync();

            return studentExams.Select(e => new StudentExamResultModelView(e));
        }

        public async Task<IEnumerable<StudentExamResultModelView>> GetBadStudents(Guid examId)
        {
            return await getListByFunctAsync(p => p.Score >= 5.0 && p.Score < 7.0 && p.ExamID == examId);
        }

        public async Task<IEnumerable<StudentExamResultModelView>> GetExcellentStudents(Guid examId)
        {
            return await getListByFunctAsync(p => p.Score >= 9.0 && p.ExamID == examId);
        }

        public async Task<IEnumerable<StudentExamResultModelView>> GetFailStudents(Guid examId)
        {
            return await getListByFunctAsync(p => p.Score < 7.0 && p.ExamID == examId);
        }

        public async Task<IEnumerable<StudentExamResultModelView>> GetGoodStudents(Guid examId)
        {
            return await getListByFunctAsync(p => p.Score >= 7.0 && p.Score < 8.0 && p.ExamID == examId);
        }

        public async Task<StudentExamResultModelView> GetResultStudentExam(Guid ExamID, Guid StudentID)    
        {
            var ResultExamStudent = await _dbcontext.StudentExams
                                        .Include(p => p.Exams)
                                        .Include(p => p.Students)
                                        .FirstOrDefaultAsync(p => p.StudentID == StudentID && p.ExamID == ExamID);
            if (ResultExamStudent != null)
            {
                var result = new StudentExamResultModelView(ResultExamStudent);
                return result;
            }
            else
            {
                return null;
            }
        }

        public async Task<StatisticalExamResultModelView> GetStatisticalTestResult(Guid examId)
        {
            var GetSuccesfulStudentCount =  (await GetSuccessfulStudents(examId)).Count();
            var GetFailStudentCount      =  (await GetFailStudents(examId)).Count();
            var GetWeakStudentCount      =  (await GetWeakStudents(examId)).Count();
            var GetBadStudentCount       =  (await GetBadStudents(examId)).Count();
            var GetGoodStudentCount      =  (await GetGoodStudents(examId)).Count();
            var GetVeryGoodStudentCount  =  (await GetVeryGoodStudents(examId)).Count();
            var GetExcellentStudentCount =  (await GetExcellentStudents(examId)).Count();

            var staticalExam = new StatisticalExamResultModelView(GetSuccesfulStudentCount
                                                                  , GetFailStudentCount     ,GetWeakStudentCount
                                                                  , GetBadStudentCount      ,GetGoodStudentCount
                                                                  , GetVeryGoodStudentCount ,GetExcellentStudentCount);
            return staticalExam;
        }

        public async Task<IEnumerable<StudentExamResultModelView>> GetSuccessfulStudents(Guid examId)
        {
            return await getListByFunctAsync(p => p.Score >= 7 && p.ExamID == examId);
        }

        public async Task<IEnumerable<StudentExamResultModelView>> GetVeryGoodStudents(Guid examId)
        {
            return await getListByFunctAsync(p => p.Score >= 8.0 && p.Score < 9.0 && p.ExamID == examId);
        }

        public async Task<IEnumerable<StudentExamResultModelView>> GetWeakStudents(Guid examId)
        {
           return await getListByFunctAsync(p => p.Score < 5.0 && p.ExamID == examId);
        }
    }
}
