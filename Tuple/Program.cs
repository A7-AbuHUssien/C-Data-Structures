using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {
        // Declare a tuple
        (int, string, double) person = (1, "Alice", 5.5);
       

        // Access tuple elements
        Console.WriteLine("ID: " + person.Item1);
        Console.WriteLine("Name: " + person.Item2);
        Console.WriteLine("Height: " + person.Item3 + " feet");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        // Using a method that returns a tuple
        (int, string, double) persen = GetValues();
        Console.WriteLine("ID: " + persen.Item1);
        Console.WriteLine("Name: " + persen.Item2);
        Console.WriteLine("Height: " + persen.Item3 + " feet");
    }
    static (int, string,double) GetValues()
    {
        return (5, "MEDO", 6.0);
    }
}
