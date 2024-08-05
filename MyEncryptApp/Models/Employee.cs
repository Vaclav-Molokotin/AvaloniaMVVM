using System;

namespace MyEncryptApp.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly Birthdate { get; set; }
    public string Gender { get; set; }
}
