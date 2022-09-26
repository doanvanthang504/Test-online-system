using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.ModelsView.SystemModelView;

namespace ThangDV29_MiniProject_WebAPI.Services.InterfaceServices
{
    public interface IAccountManagerService 
    {
        Task<IEnumerable<ListAccountModelView>> FindAllAsync();
        Task<Account> FindByIdAsync(Guid id);
        Task<SignUpResult> InsertAsync(AccountModelsView accountModelsView);
        Task<bool> DeleteAsync(Guid id);
        Task<SignUpResult> UpdateAsync(AccountModelsView accountModelsView, Guid id);
        Task<IEnumerable<Account>> GetAllTeacher();
        Task<IEnumerable<Account>> GetAllAdmin();
        Task<IEnumerable<Account>> GetAllStudent();
        Task<SignUpResult> RegisterStudent(RegisterModelView registerModelView);
        Task<SignUpResult> RegisterTeacher(RegisterModelView registerModelView);
        Task<bool> AthenticationAccount(AuthAccountModelView authModelView, Guid id);
        Task<BlockResult> BlockAccount(BlocAccountkModelView blocAccountkModel, Guid id);

    }
}
