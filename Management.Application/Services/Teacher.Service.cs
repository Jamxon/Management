
using Management.Domain.Models;
using Management.Infrastructure.Data;

namespace Management.Application.Services
{
    public class TeacherService
    {
        public DbContext dbContext { get; set; }

        public TeacherService()
        {
            this.dbContext = new DbContext();
        }
        public void AddTeacher(string firstName, string lastName, int password)
        {
            this.dbContext.Teachers = new Teacher()
            {
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName,
                Password = password
            };
        }
        public Teacher GetTeacher()
        {
            var teacher = this.dbContext.Teachers;
            return teacher;
        }
    }
}
