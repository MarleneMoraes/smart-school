using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Students: Anderson, Felipe, Ana, Luana");
        }   
    }
}