using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly IStudent _IStudent;
        public StudentController(IStudent istudent)
        {
            _IStudent = istudent;
        }
        [Route("Add")]
        [HttpPost]
        public ActionResult Add()
        {
            Student student = new Student();
            student.StudentId = 1;
            student.Name = "ABC";
            _IStudent.Add(student);
            return Ok(true);
        }
    }
}