using AutoMapper;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Services.MyServices
{
    public class LoginService : ILoginService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public LoginService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<SignUpResult> LoginAsync(string userName, string password)
        {
            var AccountLogin = _unitOfWork.LoginRepository.LoginAsync(userName, password);
            
            return AccountLogin;
        }
    }
}
