using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminResultManagerController : ControllerBase
    {
        private readonly IResultManagerService _resultManagerService;

        public AdminResultManagerController(IResultManagerService resultManagerService)
        {
            _resultManagerService = resultManagerService;
        }

        [HttpGet("GetStatiscal/Exam")]
        public async Task<IActionResult> GetStatisticalTestResult(Guid ExamID)
        {
            var result = await _resultManagerService.GetStatisticalTestResult(ExamID);
            return Ok(result);
        }

        [HttpGet("GetResultExam/Student")]
        public async Task<IActionResult> GetResultStudentExam( Guid ExamID,  Guid StudentID)
        {
            var result = await _resultManagerService.GetResultStudentExam(ExamID, StudentID);
            return Ok(result);
        }
    }
}
