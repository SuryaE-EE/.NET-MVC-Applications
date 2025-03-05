using System;
using System.Collections.Generic;

namespace EFCoreDemo4.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Ename { get; set; }

    public string? Job { get; set; }

    public decimal? Salary { get; set; }
}
