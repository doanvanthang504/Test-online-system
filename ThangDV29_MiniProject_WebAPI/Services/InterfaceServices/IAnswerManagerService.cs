using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention.CheckExtention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView.AnswerModelView;
using ThangDV29_MiniProject_WebAPI.ModelsViews;

namespace ThangDV29_MiniProject_WebAPI.Services.InterfaceServices
{
    public interface IAnswerManagerService
    {
        Task<IEnumerable<Answer>> FindAllAsync();
        Task<Answer> FindByIdAsync(Guid id);
        Task<CheckAnswer> Insert(InsertAnswerModelView insertAnswerModelView);
        Task<bool> Delete(Guid id);
        Task<CheckAnswer> Update(AnswerModelView answerModelView, Guid id);
    }
}
