using System;
using System.Collections.Generic;

namespace ConsoleAppUsingDBFirstApproach.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
