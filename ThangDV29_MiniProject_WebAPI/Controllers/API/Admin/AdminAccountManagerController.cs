using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminAccountManagerController : ControllerBase
    {
        private readonly IAccountManagerService _accountService;
        private readonly ILoggerManager _logger;

        public AdminAccountManagerController(IAccountManagerService accountService, ILoggerManager logger)
        {
            _accountService = accountService;
            _logger = logger;
        }

        
        [HttpGet("FindAllAccount")]
        public async Task<IActionResult> FindAllAsync()
        {
            var ListAccount = await _accountService.FindAllAsync();
          
            return Ok(ListAccount);
        }

        [HttpGet("FindByIDAccount")]
        public async Task<IActionResult> FindIdAsync(Guid id)
        {
            var ListAccouontById = await _accountService.FindByIdAsync(id);
            return Ok(ListAccouontById);
        }

        [HttpGet("GetAllAdmin")]
        public async Task<IActionResult> FindAdminAsync()
        {
            var account = await _accountService.GetAllAdmin();
            return Ok(account);
        }

        [HttpGet("GetAllTeacher")]
        public async Task<IActionResult> FindTeacherAsync()
        {
            var account = await _accountService.GetAllTeacher();
            return Ok(account);
        }

        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> FindStudentAsync()
        {
            var account = await _accountService.GetAllStudent();
            return Ok(account);
        }

        [HttpPost("InsertAccount")]
        public async Task<IActionResult> Insert(AccountModelsView accountModelsView)
        {
            var createAccountResult = await _accountService.InsertAsync(accountModelsView);
            if (createAccountResult.IsSuccess) return Ok("Insert Successful !!");

            return Ok(createAccountResult.ErrorMessage);
        }

        [HttpPut("UpdateAccount")]
        public async Task<IActionResult> Update([FromForm] AccountModelsView accountModelsView, Guid id)
        {
            var result = await _accountService.UpdateAsync(accountModelsView, id);
            if (result.IsSuccess)
            {
                return Ok("Update Successful !!");
            }
            else
            {
                return BadRequest("Update Fail !!");
            }
        }

        [HttpPut("AuthenticationAccount")]
        public async Task<IActionResult> AuthenticationAccount([FromForm] AuthAccountModelView autheModelView, Guid id)
        {
            var result = await _accountService.AthenticationAccount(autheModelView, id);
            if (result)
            {
                return Ok("Authentication Successful !!");
            }
            else
            {
                return BadRequest("Authentication Fail !!");
            }
        }
        [HttpPut("BlocAccount")]
        public async Task<IActionResult> BlocAccount([FromForm] BlocAccountkModelView blocAccountkModelView, Guid id)
        {
            var result = await _accountService.BlockAccount(blocAccountkModelView, id);
            if (result.IsResultBlock==true)
            {
                return Ok("Block Successful !!");
            }
            else
            {
                return Ok("Unblock Successfull !!");
            }
            
        }
    }
}
