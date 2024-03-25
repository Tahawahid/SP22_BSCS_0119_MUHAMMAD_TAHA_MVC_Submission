using System;
using System.Collections.Generic;

namespace SP22_BSCS_0119_MUHAMMAD_TAHA_MVC.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Semester { get; set; }

    public int? Age { get; set; }

    public string? Contact { get; set; }
}
