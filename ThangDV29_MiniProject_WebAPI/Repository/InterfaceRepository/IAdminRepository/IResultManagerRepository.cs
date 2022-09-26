using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.ModelsView;

namespace ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository
{
    public interface IResultManagerRepository 
    {
        Task<StudentExamResultModelView> GetResultStudentExam(Guid ExamID, Guid StudentID);
        Task<IEnumerable<StudentExamResultModelView>> GetFailStudents(Guid examId);
        Task<IEnumerable<StudentExamResultModelView>> GetSuccessfulStudents(Guid examId);
        Task<IEnumerable<StudentExamResultModelView>> GetBadStudents(Guid examId);
        Task<IEnumerable<StudentExamResultModelView>> GetWeakStudents(Guid examId);
        Task<IEnumerable<StudentExamResultModelView>> GetGoodStudents(Guid examId);
        Task<IEnumerable<StudentExamResultModelView>> GetVeryGoodStudents(Guid examId);
        Task<IEnumerable<StudentExamResultModelView>> GetExcellentStudents(Guid examId);
        Task<StatisticalExamResultModelView> GetStatisticalTestResult(Guid examId);
    }
}
