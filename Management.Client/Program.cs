using System;
using System.Diagnostics;
using Management.Application.Services;

namespace Management.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService();
            studentService.AddStudent("Jamshidbek", "Aliyev");
            studentService.AddStudent("Jamshidbek", "Aliyev");

            foreach (var student in studentService.DbContext.Students)
            {
                Console.WriteLine(
                    $"ID: {student.Id}, Name: {student.FirstName} {student.LastName}"
                );
            }
        }
    }
}
