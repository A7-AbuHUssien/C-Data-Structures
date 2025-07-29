using System;
using System.Linq;


class Program
{
    static void Main()
    {
        var employees = new[]
        {
            new { Name = "Ahmed", DepartmentId = 1 },
            new { Name = "Sara", DepartmentId = 2 },
            new { Name = "Mona", DepartmentId = 1 }
        };

        var departments = new[]
        {
            new { Id = 1, Name = "HR" },
            new { Id = 2, Name = "IT" }
        };

        var innered = employees.Join(departments, e => e.DepartmentId, d => d.Id, (e, d) => new { e.Name, department = d.Name });

        foreach (var item in innered)
        {
            Console.WriteLine($"{item.Name} works in {item.department}");
        }
    }
}