using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.ModelsView.ExamModeslViews;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Services.MyServices
{
    public class ExamManagerService : IExamManagerService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public ExamManagerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<Exam>> FindAllAsync()
        {
            var examList = await _unitOfWork.ExamRepository.FindAllAsync();
            return examList;
        }

        public async Task<IEnumerable<ExamModelView>> GetAllExamQuestion()
        {
            var examRepository = (IExamManagerRepository)_unitOfWork.ExamRepository;
            var examList = await examRepository.GetAllExamQuestion();
            return examList;
        }

        public async Task<Exam> FindByIdAsync(Guid id)
        {
            var exam = await _unitOfWork.ExamRepository.FindByIdAsync(id);
            return exam;
        }

        public async Task<CheckNameExam> InsertExam(Guid teacherId, InsertExamModelView inserExamModelView)
        {
           
            var examRepository = (IExamManagerRepository)_unitOfWork.ExamRepository;
            var findNameExam = await examRepository.FindUserByNameExam(inserExamModelView.NameExam);
            
            if (findNameExam != null)
            {
                return new CheckNameExam
                {
                    IsExists = false,
                    MessageExam = "Exam Exists"
                };
            }

            var exam = _mapper.Map<Exam>(inserExamModelView);
            _unitOfWork.ExamRepository.Insert(exam);

            foreach (var questionId in inserExamModelView.QuestionID)
            {
                var examQuestion = new ExamQuestion
                {
                    ExamID = exam.ID,
                    QuestionID = questionId,
                    TeacherID = teacherId
                };
                _unitOfWork.ExamQuestionRepository.Insert(examQuestion);
            }

            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new CheckNameExam
                {
                    IsExists = true
                };
            }
            else
            {
                return new CheckNameExam
                {
                    IsExists = false,
                    MessageExam = "SaveChange Failed !!"
                };
            }
        }

        public async Task<CheckNameExam> Update(UpdateExamModelView updateExamModelView, Guid id)
        {
            var examId = await _unitOfWork.ExamRepository.FindByIdAsync(id);

            var examRepository = (IExamManagerRepository)_unitOfWork.ExamRepository;
            var findNameExam = await examRepository.FindUserByNameExam(updateExamModelView.NameExam);
            if (findNameExam != null)
            {
                return new CheckNameExam
                {
                    IsExists = false,
                    MessageExam = "Exam Exists"
                };
            }

            examId.NameExam = updateExamModelView.NameExam;
            examId.DateExam = updateExamModelView.DateExam;
            examId.TimeExam = updateExamModelView.TimeExam;

            _unitOfWork.ExamRepository.Update(examId);
            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new CheckNameExam
                {
                    IsExists = true
                };
            }
            else
            {
                return new CheckNameExam
                {
                    IsExists = false,
                    MessageExam = "SaveChange Failed !!"
                };
            }
        }
    }
}
