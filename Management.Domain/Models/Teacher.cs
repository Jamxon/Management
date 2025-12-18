using System;

namespace Management.Domain.Models;

public class Teacher
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = "admin";
    public string LastName { get; set; } = "admin";
    public string Username { get; set; } = "admin";
    public string Password { get; set; } = "admin";
}
