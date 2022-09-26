using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView.SystemModelView;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;

namespace ThangDV29_MiniProject_WebAPI.Repository.MyRepository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IApplicationDBContext _dbcontext;
        private readonly Appsetting _appseting;

        public LoginRepository(IApplicationDBContext dbcontext, IOptionsMonitor<Appsetting> optionsMonitor)
        {
            _dbcontext = dbcontext;
            _appseting = optionsMonitor.CurrentValue;
        }

        public string GenerateToken(Account account)
        {
            var JwtTokenhandler = new JwtSecurityTokenHandler();
            var secretKeyBytes = Encoding.UTF8.GetBytes(_appseting.SecretKey);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName, account.FullName.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, account.Email),
                    new Claim("Id", account.ID.ToString()),
                    new Claim("UserName", account.Username),
                    new Claim("IsAuthentication", account.IsAuthentication.ToString()),
                    new Claim("IsBloc", account.IsBLock.ToString()),
                    new Claim(JwtRegisteredClaimNames.Birthdate, account.BirthDay.ToString()),
                    new Claim(JwtRegisteredClaimNames.AuthTime, account.DateCreate.ToString()),
                    new Claim(ClaimTypes.Role, account.Role.ToString()),

                    new Claim("TokenID", Guid.NewGuid().ToString()),
                    new Claim("TokenName", "Token is me")
                }),

                Expires = DateTime.UtcNow.AddMinutes(21),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                                                             SecurityAlgorithms.HmacSha512Signature)
            };
            var token = JwtTokenhandler.CreateToken(tokenDescription);
            return JwtTokenhandler.WriteToken(token);
        }

        public async Task<SignUpResult> LoginAsync(string userName, string password)
        {
            var user = await _dbcontext.Accounts.SingleOrDefaultAsync(e => e.Username == userName);

            if (user != null)
            {
                if (user.IsBLock == false && user.IsAuthentication == true)
                {
                    var verifyPwd = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

                    if (verifyPwd == true)
                    {
                        return new SignUpResult()
                        {
                            IsSuccess = true,
                            ErrorMessage = "Login Successful !!",
                            Token = GenerateToken(user)
                        };
                    }
                    return new SignUpResult()
                    {
                        IsSuccess = false,
                        ErrorMessage = "Login Fail !!"
                    };
                }
                else
                {
                    return new SignUpResult()
                    {
                        IsSuccess = false,
                        ErrorMessage = "Login Fail !!"
                    };
                }
            }
            return new SignUpResult()
            {
                IsSuccess = false,
                ErrorMessage = "Login Fail !!"
            };

        }
    }
    
}
