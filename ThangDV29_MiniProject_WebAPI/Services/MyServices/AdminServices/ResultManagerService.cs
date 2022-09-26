using AutoMapper;
using System;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Services.MyServices
{
    public class ResultManagerService : IResultManagerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ResultManagerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<StudentExamResultModelView> GetResultStudentExam(Guid ExamID, Guid StudentID)
        {
            return await _unitOfWork.ResultManagerRepository.GetResultStudentExam(ExamID, StudentID);
        }

        public async Task<StatisticalExamResultModelView> GetStatisticalTestResult(Guid ExamId)
        {
            return await _unitOfWork.ResultManagerRepository.GetStatisticalTestResult(ExamId);
        }
    }
}
