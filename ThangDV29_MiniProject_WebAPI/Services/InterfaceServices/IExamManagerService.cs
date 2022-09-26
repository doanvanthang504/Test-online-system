using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.ModelsView.ExamModeslViews;

namespace ThangDV29_MiniProject_WebAPI.Services.InterfaceServices
{
    public interface IExamManagerService
    {
        Task<IEnumerable<Exam>> FindAllAsync();
        Task<Exam> FindByIdAsync(Guid id);
        Task<CheckNameExam> InsertExam(Guid teacherId, InsertExamModelView inserExamModelView);
        Task<CheckNameExam> Update(UpdateExamModelView updateExamModelView, Guid id);
        Task<IEnumerable<ExamModelView>> GetAllExamQuestion();
    }
}
