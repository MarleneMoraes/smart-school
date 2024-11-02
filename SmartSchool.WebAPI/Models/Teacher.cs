using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
    public class Teacher
    {
        public Teacher() { }
        public Teacher(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}