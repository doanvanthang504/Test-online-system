using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;

namespace ThangDV29_MiniProject_WebAPI.Repository
{
    public class AccountManagerRepository : GenericRepository<Account>, IAccountManagerRepository
    {
        public AccountManagerRepository(IApplicationDBContext dbContext) : base(dbContext)
        { }

        public Task<IEnumerable<Account>> FindAccountByRoleAdmin()
        {
            var result = Find(e => e.Role == Models.Enum.Roles.Admin);
            if (result == null)
            {
                return null;
            }
            return result;
        }
        public Task<IEnumerable<Account>> FindAccountByRoleTeacher()
        {
            var result = Find(e => e.Role == Models.Enum.Roles.Teacher);
            if (result == null) return null;
            return result;
        }
        public Task<IEnumerable<Account>> FindAccountByRoleStudent()
        {
            var result = Find(e => e.Role == Models.Enum.Roles.Student);
            if (result == null) return null;
            return result;
        }

        public async Task<Account> FindUserByUsername(string username)
        {
            var result = await _dbSet.FirstOrDefaultAsync(e => e.Username == username);
            if (result == null) return result;
            return result;
        }

        public void AthenticationAccount(Account account)
        {
             _dbSet.Update(account);
        }

        public void BlocAccount(Account account)
        {
            _dbSet.Update(account);
        }
    }
}
