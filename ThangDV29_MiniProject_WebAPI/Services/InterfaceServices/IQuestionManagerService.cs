using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;

namespace ThangDV29_MiniProject_WebAPI.Services.InterfaceServices
{
    public interface IQuestionManagerService
    {
        Task<IEnumerable<GetQuestionModelView>> FindAllAsync();
        Task<Question> FindByIdAsync(Guid id);
        Task<CheckNameQuestion> Insert(EditQuestionsModelView questionsModelView);
        Task<bool> Delete(Guid id);
        Task<CheckNameQuestion> Update(EditQuestionsModelView questionsModelView, Guid id);
      
    }
}
