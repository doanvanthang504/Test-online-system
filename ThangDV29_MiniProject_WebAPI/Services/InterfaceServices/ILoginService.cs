using System.Threading.Tasks;

namespace ThangDV29_MiniProject_WebAPI.Services.InterfaceServices
{
    public interface ILoginService
    {
        public Task<SignUpResult> LoginAsync(string userName, string password);
    }
}
