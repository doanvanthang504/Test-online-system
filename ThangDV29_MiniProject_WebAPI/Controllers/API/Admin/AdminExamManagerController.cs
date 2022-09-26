using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.ModelsView.ExamModeslViews;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API.ManagerAccount
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminExamManagerController : ControllerBase
    {
        private readonly IExamManagerService _examManagerService;
        private readonly ILoggerManager _logger;

        public AdminExamManagerController(IExamManagerService examManagerService, ILoggerManager logger)
        {
            _examManagerService = examManagerService;
            _logger = logger;
        }
        [HttpGet("GetAllExam")]
        public async Task<IActionResult> GetAllExam()
        {
            var listExam = await _examManagerService.GetAllExamQuestion();
            return Ok(listExam);
        }

        [HttpPost("AddExam")]
        public async Task<IActionResult> InsertExam([FromForm] InsertExamModelView inserExamModelView)
        {
            var teacherId = Guid.Parse(HttpContext.Items["Id"].ToString());
            var result = await _examManagerService.InsertExam(teacherId, inserExamModelView);
            if (result.IsExists)
            {
                return Ok(" Insert Exam Successful !!");
            }
            return Ok(result.MessageExam);
        }

        [HttpPut("Edit Exam")]
        public async Task<IActionResult> UpdateExam([FromForm] UpdateExamModelView updateExamModelView, Guid id)
        {
            var result = await _examManagerService.Update(updateExamModelView, id);
            if (result.IsExists)
            {
                return Ok("Update Successful !!");
            }
            return Ok(result.MessageExam);
        }
    }
}
