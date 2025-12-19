using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Models;
using Management.Infrastructure.Data;

namespace Management.Application.Services
{
    public class StudentService
    {
        public DbContext dbcontext { get; set; }
        private int _index = 0;
        public StudentService()
        {
            this.dbcontext= new DbContext();
        }
        public void AddStudents(string firstName, string lastName)
        {
            if (_index >= this.dbcontext.Students.Length)
                return;

            this.dbcontext.Students[_index] = new Student()
            {
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName
            };

            _index++;
        }

        public Student[] GetStudents()
        {
            var students = this.dbcontext.Students;
            return students;
        }
    }
}
