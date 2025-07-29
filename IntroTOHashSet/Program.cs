using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating a HashSet of strings
        HashSet<string> fruits = new HashSet<string> { "Apple", "Banana", "Cherry" };

        // Add
        fruits.Add("Orange");

        // Search
        Console.WriteLine(fruits.Contains("Orange") ? "Exists" : "Not Exists");

        // Remove
        fruits.Remove("Orange");

        // Using HashSet to Remove Duplicates
        int[] arr = { 1, 2, 3, 4, 3, 4, 2, 5 };
        HashSet<int> mynums = new HashSet<int>(arr);
        arr = mynums.ToArray();
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        // Clear
        fruits.Clear();

    }
}