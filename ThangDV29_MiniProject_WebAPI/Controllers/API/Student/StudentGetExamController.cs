using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.ModelsView.StudentGetExamModelView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;

namespace ThangDV29_MiniProject_WebAPI.Controllers.API.Student
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Student")]
    public class StudentGetExamController : ControllerBase
    {
        private readonly IStudentService _studentGetExamService;

        public StudentGetExamController(IStudentService studentGetExamService)
        {
            _studentGetExamService = studentGetExamService;
           
        }

        [HttpGet]
        public async Task<IActionResult> StudentGetExam(Guid ExamID)
        {
            var result = await _studentGetExamService.StudentGetExam(ExamID);
            return Ok(result);
        } 
    }
}
