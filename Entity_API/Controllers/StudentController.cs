using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_API.IServices;
using Entity_API.Models;

namespace Entity_API.Controllers
{
    [Route("api")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [Route("[controller]")]
        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(_studentService.GetListStudents());
        }
        [Route("[controller]/{id}")]
        [HttpGet]
        public IActionResult GetStudent(Guid id)
        {
            var std = _studentService.GetStudent(id);
            return Ok(std);
        }
        [Route("[controller]")]
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (student != null)
            {
                _studentService.AddStudent(student);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + student.Id, student);

            }

            return NotFound("Thêm ko thành công");
        }
        [HttpDelete]
        [Route("[controller]/{id}")]
        public IActionResult DeleteStudent(Guid id)
        {
            var std = _studentService.GetStudent(id);
            if (std != null)
            {
                _studentService.DeleteStudent(std);
                return Ok("Xoa thanh cong");
            }

            return NotFound("Khong tim thay sinh vien");
        }
        [HttpPatch]
        [Route("[controller]/{id}")]
        public IActionResult EditStudent(Guid id, Student student)
        {
            var std = _studentService.GetStudent(id);
            if (std == null) return NotFound("Khong tim thay sinh vien");
            student.Id = std.Id;
            _studentService.EditStudent(student);
            return Ok("Sua thanh cong");
        }

    }
}
