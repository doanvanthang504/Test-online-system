using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly ILoggerManager _logger;

        public LoginController(ILoginService loginservice, ILoggerManager logger)
        {
            _loginService = loginservice;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginModelview loginModelView)
        {
          var result = await _loginService.LoginAsync(loginModelView.Username, loginModelView.Password);
            if(result.IsSuccess)
            {
                return Ok(result.Token);
            }
            return Ok(result.ErrorMessage);
        }
    }
}
