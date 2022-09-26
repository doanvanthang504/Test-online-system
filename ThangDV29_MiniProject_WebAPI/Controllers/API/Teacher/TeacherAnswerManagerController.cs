using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.ModelsView.AnswerModelView;
using ThangDV29_MiniProject_WebAPI.ModelsViews;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API.Teacher
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Teacher")]
    public class TeacherAnswerManagerController : ControllerBase
    {
        private readonly IAnswerManagerService _answerManagerService;

        public TeacherAnswerManagerController(IAnswerManagerService answerManagerService)
        {
            _answerManagerService = answerManagerService;
        }

        [HttpGet("GetAllAnswer")]
        public async Task<IActionResult> FindAll()
        {
            var listAnswer = await _answerManagerService.FindAllAsync();
            return Ok(listAnswer);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> FindById(Guid id)
        {
            var result = await _answerManagerService.FindByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("AddAnswer")]
        public async Task<IActionResult> InsertAnswer([FromForm] InsertAnswerModelView insertAnswerModelView)
        {
            var result = await _answerManagerService.Insert(insertAnswerModelView);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPut("Edit Answer")]
        public async Task<IActionResult> UpdateExam([FromForm] AnswerModelView answerModel, Guid id)
        {
            var result = await _answerManagerService.Update(answerModel, id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return Ok(result.Message);
        }
    }
}

