using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
    public class Student
    {
        public Student() { }
        public Student(int id, string name, string lastName, string telephone)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Telephone = telephone;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
    }
}