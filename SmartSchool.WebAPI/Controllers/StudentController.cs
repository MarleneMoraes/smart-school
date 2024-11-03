using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public List<Student> Students = new List<Student>()
        {
            new Student() { 
                Id = 1, 
                Name = "Marcos", 
                LastName = "Almeida",
                Telephone = "91234-5678" 
            },
            new Student() { 
                Id = 2, 
                Name = "Marta", 
                LastName = "Kent",
                Telephone = "98765-4321" 
            },
            new Student() { 
                Id = 3, 
                Name = "Laura", 
                LastName = "Maria",
                Telephone = "91234-8765" 
            }
        };
        public StudentController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Students);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var student = Students.FirstOrDefault(a => a.Id == id);
            if (student == null) return BadRequest("Student not found");
            return Ok(student);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name, string lastName)
        {
            var student = Students.FirstOrDefault(a => a.Name == name && a.LastName == lastName);
            if (student == null) return BadRequest("Student not found");
            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            
            return Ok(student);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            return Ok();
        }
    }
}