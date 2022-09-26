using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API.System
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IAccountManagerService _accountService;

        public RegisterController(IAccountManagerService accountService)
        {
            _accountService = accountService;
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost("RegisterTeacher")]
        public async Task<IActionResult> RegisterTeacher([FromForm] RegisterModelView registerModelView)
        {
            var createAccountResult = await _accountService.RegisterTeacher(registerModelView);
            if (createAccountResult.IsSuccess) return Ok("Register Teacher Successful !!");

            return Ok(createAccountResult.ErrorMessage);
        }

        [Authorize(Roles = "Student")]
        [HttpPost("RegisterStudent")]
        public async Task<IActionResult> RegisterAsync([FromForm] RegisterModelView registerModelView)
        {
            var createAccountResult = await _accountService.RegisterStudent(registerModelView);
            if (createAccountResult.IsSuccess) return Ok("Register Student Successful !!");

            return Ok(createAccountResult.ErrorMessage);
        }
    }
}
