using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        public TeacherController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Teachers: Marta, Paula, Lucas, Rafael");
        }   
    }
}