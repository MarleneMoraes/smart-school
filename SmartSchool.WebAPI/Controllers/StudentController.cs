using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly DataContext context;

        public StudentController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.context.Students);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var student = this.context.Students.FirstOrDefault(a => a.Id == id);
            if (student == null) return BadRequest("Student not found");
            return Ok(student);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name, string lastName)
        {
            var student = this.context.Students.FirstOrDefault(a => a.Name == name && a.LastName == lastName);
            if (student == null) return BadRequest("Student not found");
            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            this.context.Add(student);
            this.context.SaveChanges();

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            this.context.Update(student);
            this.context.SaveChanges();

            return Ok(student);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            var s = this.context.Students.FirstOrDefault(a => a.Id == id);
            if (s == null) return BadRequest("Student not found");
            
            this.context.Update(student);
            this.context.SaveChanges();

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = this.context.Students.FirstOrDefault(a => a.Id == id);
            if (student == null) return BadRequest("Student not found");

            this.context.Remove(student);
            this.context.SaveChanges();

            return Ok();
        }
    }
}