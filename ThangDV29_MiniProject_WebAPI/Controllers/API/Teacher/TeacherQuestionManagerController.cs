using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API.Teacher
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Teacher")]
    public class TeacherQuestionManagerController : ControllerBase
    {
        private readonly IQuestionManagerService _questionManagerService;

        public TeacherQuestionManagerController(IQuestionManagerService questionManagerService)
        {
            _questionManagerService = questionManagerService;
        }

        [HttpGet("GetAllQuestion")]
        public async Task<IActionResult> FindAll()
        {
            var listQuestion = await _questionManagerService.FindAllAsync();
            return Ok(listQuestion);
        }
        [HttpGet("FindById")]
        public async Task<IActionResult> FindById(Guid id)
        {
            var result = await _questionManagerService.FindByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("AddQuestion")]
        public async Task<IActionResult> InsertExam([FromForm] EditQuestionsModelView questionsModelView)
        {
            var result = await _questionManagerService.Insert(questionsModelView);
            if (result.IsExistss)
            {
                return Ok(result.MessageQuestion);
            }
            return Ok(result.MessageQuestion);
        }

        [HttpPut("Edit Question")]
        public async Task<IActionResult> UpdateExam([FromForm] EditQuestionsModelView questionsModelView, Guid id)
        {
            var result = await _questionManagerService.Update(questionsModelView, id);
            if (result.IsExistss)
            {
                return Ok(result.MessageQuestion);
            }
            return Ok(result.MessageQuestion);
        }
    }
}
