using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepo;

namespace ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository
{
    interface IAccountManagerRepository : IGenericRepository<Account>
    {
        Task<Account> FindUserByUsername(string username);
        void AthenticationAccount(Account account);
        void BlocAccount(Account account);
        Task<IEnumerable<Account>> FindAccountByRoleTeacher();
        Task<IEnumerable<Account>> FindAccountByRoleAdmin();
        Task<IEnumerable<Account>> FindAccountByRoleStudent();

    }
}
