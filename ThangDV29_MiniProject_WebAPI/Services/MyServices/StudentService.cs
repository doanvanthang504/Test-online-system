using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.DTO;
using ThangDV29_MiniProject_WebAPI.DTO.ModelsView.StudentModelView;
using ThangDV29_MiniProject_WebAPI.ModelsView.StudentGetExamModelView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Services.MyServices
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<StudentListStatusModelView>> ExamResultStatus(Guid studentID)
        {
            var result = await _unitOfWork.StudentRepository.ExamResultStatus(studentID);
            return result;
        }

        public async Task<HistoryExamStudentModelView> GetHistoryExam(Guid studentId)
        {
            var result = await _unitOfWork.StudentRepository.GetHistoryExam(studentId);
            if (result == null)
            {
                return null;
            }
            return result;
        }

        public async Task<StudentGetExamModelView> StudentGetExam(Guid ExamID)
        {
            var result = await _unitOfWork.StudentRepository.StudentGetExam(ExamID);
            if (result == null)
            {
                return null;
            }
            return result;
        }

        public async Task<ScoreStudent> SubmitExamStudent(Guid examID, Guid studentID,
                                                    Dictionary<Guid, List<Guid>> answers)
        {
            var score = await _unitOfWork.StudentRepository.SubmitExamStudent(examID, studentID, answers);
            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new ScoreStudent
                {
                    IsSucceed = true,
                    Score = score.Score
                };

            }
            return new ScoreStudent();
        }
    }
}
