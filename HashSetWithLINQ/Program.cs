using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating and populating a HashSet of strings
        HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };

        // Using LINQ to filter names that start with 'C'
        var stC = names.Where(n => n.StartsWith("C"));

        // Using LINQ to find names with length greater than 4 characters
        var gt4 = names.Where(x => x.Length > 4);

        // Test
        foreach (var name in gt4)
        {
            Console.WriteLine(name);
        }


    }
}