using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;

namespace ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository
{
    public interface ILoginRepository 
    {
        public Task<SignUpResult> LoginAsync(string userName, string password);
        public string GenerateToken(Account account);
    }
}
