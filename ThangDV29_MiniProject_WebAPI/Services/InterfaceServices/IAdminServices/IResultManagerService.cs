using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models.Table;
using ThangDV29_MiniProject_WebAPI.ModelsView;

namespace ThangDV29_MiniProject_WebAPI.Services.InterfaceServices
{
    public interface IResultManagerService
    {
        Task<StudentExamResultModelView> GetResultStudentExam(Guid ExamID, Guid StudentID);
       
        Task<StatisticalExamResultModelView> GetStatisticalTestResult(Guid examId);
    }
}
