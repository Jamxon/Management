using System;
using Management.Domain.Models;
using Management.Infrastructure.Data;

namespace Management.Application.Services;

public class TeacherService
{
    public DbContext DbContext { get; set; }

    public TeacherService()
    {
        this.DbContext = new DbContext();
    }

    public void AddTeacher(string firstName, string lastName, string username, string password)
    {
        Teacher newTeacher = new Teacher
        {
            Id = Guid.NewGuid().ToString().Substring(0, 5),
            FirstName = firstName,
            LastName = lastName,
            Username = username,
            Password = password,
        };
        var list = this.DbContext.Teachers.ToList();
        list.Add(newTeacher);
        this.DbContext.Teachers = list.ToArray();
    }

    public Teacher[] GetTeachers()
    {
        return this.DbContext.Teachers.ToArray();
    }

    public int GetTeacherCount()
    {
        return this.DbContext.Teachers.Length;
    }
}
