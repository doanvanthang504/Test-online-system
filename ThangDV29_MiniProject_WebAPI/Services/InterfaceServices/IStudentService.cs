using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.DTO;
using ThangDV29_MiniProject_WebAPI.DTO.ModelsView.StudentModelView;
using ThangDV29_MiniProject_WebAPI.ModelsView.StudentGetExamModelView;

namespace ThangDV29_MiniProject_WebAPI.Services.InterfaceServices
{
    public interface IStudentService
    {
        Task<StudentGetExamModelView> StudentGetExam(Guid ExamID);
        Task<IEnumerable<StudentListStatusModelView>> ExamResultStatus(Guid studentID);

        Task<ScoreStudent> SubmitExamStudent(Guid examID, Guid studentID,
                                                    Dictionary<Guid, List<Guid>> answers);
        Task<HistoryExamStudentModelView> GetHistoryExam(Guid studentId);
    }
}
