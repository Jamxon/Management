using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Models;

namespace Management.Infrastructure.Data
{
    public class DbContext
    {
        public DbContext()
        {
            Students = new Student[] { new Student() };
        }

        public Student[] Students { get; set; }
        public int StudentCount { get; set; } = 0;

        public void AddStudent(Student student)
        {
            List<Student> students = Students.ToList();
            students.Add(student);
            Students = students.ToArray();
        }
    }
}
