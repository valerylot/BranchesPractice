using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BranchesPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace BranchesPractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        //constructor to inject the services
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("getall")]
        public ActionResult<List<string>> StudentGetAll()
        {
            return Ok(_studentService.StudentGetAll());
        }

        [HttpGet("getcount")]
        public ActionResult<int> GetCount()
        {
            return Ok(_studentService.StudentCount());
        }
    }
}