using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> numbers = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filter
        var FilteredSet = numbers.Where(x => x > 2);
        Console.Write("(Numbers > 2) : ");
        foreach (var item in FilteredSet)
        {
            Console.Write(item + " ");
        }


        // Some Operation
        Console.WriteLine($"\nSum : {numbers.Sum()}");
        Console.WriteLine($"Max : {numbers.Max()}");
        Console.WriteLine($"Min : {numbers.Min()}");

        // descending order
        var descendingSet = numbers.OrderBy(x => x);
        Console.Write("Descending Sorted Set: ");
        foreach (var item in descendingSet)
        {
            Console.Write(item + " ");
        }
        Console.Write("\n~~~~~~~~~~~~~~~~\n");



        // Find even numbers and project them to their square
        var SquaredEvenNums = numbers.Where(x => x % 2 == 0).Select(x => x * x);
        Console.Write("Squares of even numbers: ");
        foreach (var item in SquaredEvenNums)
        {
            Console.Write(item + " ");
        }
        Console.Write("\n~~~~~~~~~~~~~~~~");

        // Union, Intersection, Difference, Subset, Superset, and Equality
        SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
        SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };

        // Union
        var union = new SortedSet<int>(set1);
        union.UnionWith(set2);
        Console.WriteLine("\nUnion: " + string.Join(" ", union));

        // Intersection
        var intersection = new SortedSet<int>(set1);
        intersection.IntersectWith(set2);
        Console.WriteLine("Intersection: " + string.Join(" ", intersection));

        // Difference (set1 - set2)
        var difference = new SortedSet<int>(set1);
        difference.ExceptWith(set2);
        Console.WriteLine("Difference: " + string.Join(" ", difference));

        // Subset, Superset, and Equality checks
        Console.WriteLine($"IsSubset: {set1.IsSubsetOf(set2)}");        
        Console.WriteLine($"IsSuperset: {set1.IsSupersetOf(set2)}");
        Console.WriteLine($"AreEqual: {set1.SetEquals(set2)}");

    }
}