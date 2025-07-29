using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize a SortedList with integer keys and fruit names as values
        SortedList<int, string> Fruits = new SortedList<int, string>
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Elderberry" },
            { 6, "Fig" },
            { 7, "Grape" },
            { 8, "Honeydew" },
            { 9, "Kiwi" },
            { 10, "Lemon" }
        };


        // Query using Query Expression Syntax
        var queryExpressionSyntax = from kvp in Fruits
                                    where kvp.Key > 5 
                                    select kvp;
        Console.WriteLine("Query Expression Syntax Results (keys > 5):");
        foreach (var item in queryExpressionSyntax)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


        // Query using Method Syntax
        var methodSyntax = Fruits.Where(kvp => kvp.Key > 5); 
        Console.WriteLine("\nMethod Syntax Results (keys > 5):");
        foreach (var item in methodSyntax)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


        // Grouping fruits by the length of their names
        Console.WriteLine("Grouping fruits by the length of their names:");
        var groups = Fruits.GroupBy(kvp => kvp.Value.Length);
        foreach (var group in groups)
        {
            Console.WriteLine($"Name Length {group.Key}: {string.Join(", ", group.Select(kvp => kvp.Value))}");
        }
    }
}
