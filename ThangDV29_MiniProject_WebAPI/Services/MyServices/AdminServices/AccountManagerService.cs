using AutoMapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.ModelsView.SystemModelView;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Services.MyServices
{
    public class AccountManagerService : IAccountManagerService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public AccountManagerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> AthenticationAccount(AuthAccountModelView authModelView, Guid id)
        {
            var findAccount = await _unitOfWork.AccountRepository.FindByIdAsync(id);

            if (findAccount == null)
            {
                throw new Exception();
            }

            findAccount.IsAuthentication = authModelView.IsAuthentication;
            _unitOfWork.AccountRepository.Update(findAccount);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result == false)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<BlockResult> BlockAccount(BlocAccountkModelView blocAccountkModel, Guid id)
        {
            var findAccount = await _unitOfWork.AccountRepository.FindByIdAsync(id);

            if (findAccount == null)
            {
                throw new Exception();
            }

            findAccount.IsBLock = blocAccountkModel.IsBLock;
            _unitOfWork.AccountRepository.Update(findAccount);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result == true && blocAccountkModel.IsBLock == true)
            {
                return new BlockResult
                {
                    IsResultBlock = true,
                };
            }
            else if (result == true && blocAccountkModel.IsBLock == false)
            {
                return new BlockResult
                {
                    IsResultBlock = false,  
                };
            }
            return new BlockResult
            {
                MessageBlock = "Block Fail !!"
            };
        }

        // DELETED
        public async Task<bool> DeleteAsync(Guid id)
        {
            var account = await FindByIdAsync(id);
            _unitOfWork.AccountRepository.Delete(account);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result == false)
            {
                throw new Exception();
            }
            return result;
        }

        // ALL
        public async Task<IEnumerable<ListAccountModelView>> FindAllAsync()
        {
            var ListAccount = await _unitOfWork.AccountRepository.FindAllAsync();
            var result = ListAccount.Select(e => new ListAccountModelView(e));
            return result ;
        }

        // FIND ID
        public async Task<Account> FindByIdAsync(Guid id)
        {
            var account = await _unitOfWork.AccountRepository.FindByIdAsync(id);
            return account;
        }

        //FIND ADMIN
        public async Task<IEnumerable<Account>> GetAllAdmin()
        {
            var accountRepo = (IAccountManagerRepository)_unitOfWork.AccountRepository;
            var numberOfTeacher = await accountRepo.FindAccountByRoleAdmin();
            return numberOfTeacher;
        }

        //FIND STUDENT
        public async Task<IEnumerable<Account>> GetAllStudent()
        {
            var accountRepo = (IAccountManagerRepository)_unitOfWork.AccountRepository;
            var numberOfTeacher = await accountRepo.FindAccountByRoleStudent();
            return numberOfTeacher;
        }
        //FIND TEACHER
        public async Task<IEnumerable<Account>> GetAllTeacher()
        {
            var accountRepo = (IAccountManagerRepository)_unitOfWork.AccountRepository;
            var numberOfTeacher = await accountRepo.FindAccountByRoleTeacher();
            return numberOfTeacher;
        }

        // ADD
        public async Task<SignUpResult> InsertAsync(AccountModelsView accountModelsView)
        {
            var accountRepository = (IAccountManagerRepository)_unitOfWork.AccountRepository;
            var foundAccount = await accountRepository.FindUserByUsername(accountModelsView.Username);
            if (foundAccount != null)
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "User Name Exists !!"
                };
            }
            var account = _mapper.Map<Account>(accountModelsView);
            account.PasswordHash = BCrypt.Net.BCrypt.HashPassword(accountModelsView.Password);
            account.DateCreate = DateTime.Now;
            _unitOfWork.AccountRepository.Insert(account);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new SignUpResult
                {
                    IsSuccess = true
                };
            }
            else
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "Insert Failed !!"
                };
            }
        }

        //STUDENT
        public async Task<SignUpResult> RegisterStudent(RegisterModelView registerModelView)
        {
            var accountRepository = (IAccountManagerRepository)_unitOfWork.AccountRepository;
            var foundAccount = await accountRepository.FindUserByUsername(registerModelView.Username);
            if (foundAccount != null)
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "User Name Exists !!"
                };
            }
            var account = _mapper.Map<Account>(registerModelView);
            account.PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerModelView.Password);
            account.Role = Models.Enum.Roles.Student;
            account.BirthDay = DateTime.ParseExact(registerModelView.BirthDay, "dd/MM/yyyy", null, DateTimeStyles.None);
            account.DateCreate = DateTime.Now;

            _unitOfWork.AccountRepository.Insert(account);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new SignUpResult
                {
                    IsSuccess = true
                };
            }
            else
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "Register Failed !!"
                };
            }
        }

        // TEACHER
        public async Task<SignUpResult> RegisterTeacher(RegisterModelView registerModelView)
        {
            var accountRepository = (IAccountManagerRepository)_unitOfWork.AccountRepository;
            var foundAccount = await accountRepository.FindUserByUsername(registerModelView.Username);
            if (foundAccount != null)
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "User Name Exists !!"
                };
            }
            var account = _mapper.Map<Account>(registerModelView);
            account.PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerModelView.Password);
            account.Role = Models.Enum.Roles.Teacher;
            account.BirthDay = DateTime.ParseExact(registerModelView.BirthDay, "dd/MM/yyyy", null, DateTimeStyles.None);
            account.DateCreate = DateTime.Now;

            _unitOfWork.AccountRepository.Insert(account);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new SignUpResult
                {
                    IsSuccess = true
                };
            }
            else
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "Register Failed !!"
                };
            }
        }

        //UPDATE
        public async Task<SignUpResult> UpdateAsync(AccountModelsView accountModelsView, Guid id)
        {
            var findAccountId = await _unitOfWork.AccountRepository.FindByIdAsync(id);

            if (findAccountId == null)
            {
                throw new Exception();
            }
            var accountRepository = (IAccountManagerRepository)_unitOfWork.AccountRepository;
            var foundAccountName = await accountRepository.FindUserByUsername(accountModelsView.Username);
            if (foundAccountName != null)
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "User Name Exists !!"
                };
            }

            findAccountId.Email = accountModelsView.Email;
            findAccountId.FullName = accountModelsView.FullName;
            findAccountId.Username = accountModelsView.Username;
            findAccountId.PasswordHash = BCrypt.Net.BCrypt.HashPassword(accountModelsView.Password);
            findAccountId.DateCreate = accountModelsView.DateCreate;
            findAccountId.BirthDay = accountModelsView.BirthDay;
            findAccountId.IsAuthentication = accountModelsView.IsAuthentication;
            findAccountId.IsBLock = accountModelsView.IsBLock;

            _unitOfWork.AccountRepository.Update(findAccountId);
            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new SignUpResult
                {
                    IsSuccess = true
                };
            }
            else
            {
                return new SignUpResult
                {
                    IsSuccess = false,
                    ErrorMessage = "Update Failed !!"
                };
            }
        }
    }
}
