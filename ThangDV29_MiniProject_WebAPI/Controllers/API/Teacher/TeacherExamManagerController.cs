using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API.Teacher
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Teacher")]
    public class TeacherExamManagerController : ControllerBase
    {
        private readonly IExamManagerService _examManagerService;
        private readonly IResultManagerService _resultManagerService;

        public TeacherExamManagerController(IExamManagerService examManagerService, IResultManagerService resultManagerService)
        {
            _examManagerService = examManagerService;
            _resultManagerService = resultManagerService;
        }
        [HttpPost("CreateExamWithManyQuestion")]
        public async Task<IActionResult> CreateExamWithManyQuestion([FromForm] InsertExamModelView inserExamModelView)
        {
            var teacherId = Guid.Parse(User.FindFirstValue("Id"));

            var result = await _examManagerService.InsertExam(teacherId, inserExamModelView);
            if (result.IsExists)
            {
                return Ok(" Insert Exam Successful !!");
            }
            return Ok(result.MessageExam);
        }

        [HttpGet("GetStatiscal/Exam")]
        public async Task<IActionResult> GetStatisticalTestResult(Guid ExamID)
        {
            var result = await _resultManagerService.GetStatisticalTestResult(ExamID);
            return Ok(result);
        }
    }
}
