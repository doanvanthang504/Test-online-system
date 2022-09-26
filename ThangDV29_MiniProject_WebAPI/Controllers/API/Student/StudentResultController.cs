using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.DTO.ModelsView.StudentModelView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API.Student
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Student")]
    public class StudentResultController : ControllerBase
    {
        private readonly IResultManagerService _resultManagerService;
        private readonly IStudentService _studentService;

        public StudentResultController(IResultManagerService resultManagerService, IStudentService studentService)
        {
            _resultManagerService = resultManagerService;
            _studentService = studentService;
        }
        [HttpGet("GetResultExam/Student")]
        public async Task<IActionResult> GetResultStudentExam(Guid ExamID)
        {
            var studentID = Guid.Parse(User.FindFirstValue("Id"));
            var result = await _resultManagerService.GetResultStudentExam(ExamID, studentID);
            return Ok(result);
        }

        [HttpGet("GetExamStatus")]
        public async Task<IActionResult> ExamResultStatus()
        {
            var studentID = Guid.Parse(User.FindFirstValue("Id"));
            var result = await _studentService.ExamResultStatus(studentID);
            return Ok(result);
        }


        [HttpPost("GetScoreAfterExam")]
        public async Task<IActionResult> StudentSubmitExam(Guid examId, [FromBody] Dictionary<Guid, List<Guid>> answers)
        {
            var studentId = Guid.Parse(User.FindFirstValue("Id"));
            var result = await _studentService.SubmitExamStudent(examId, studentId, answers);
            return Ok(result);
        }
        [HttpGet("GetHistoryExam")]
        public async Task<IActionResult> GetHistoryExam()
        {
            var studentID = Guid.Parse(User.FindFirstValue("Id"));
            var result = await _studentService.GetHistoryExam(studentID);
            if (result == null) return Ok("HistoryExam Fail !!");
            return Ok(result);
        }
    }
}