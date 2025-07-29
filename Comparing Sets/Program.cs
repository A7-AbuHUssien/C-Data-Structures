using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3 , 4, 5 };

        // Equals?
        Console.WriteLine("set1 equals set2: " + set1.SetEquals(set2));

        // Is Subset Of?
        Console.WriteLine("set1 Subset OF set2: " + set1.IsSubsetOf(set2));

        // Is SuperSet Of?
        Console.WriteLine("set1 is a superset of set2: " + set2.IsSupersetOf(set1));

        // Is Overlaps? => Means => is any InterSection
        Console.WriteLine("set2 is Overlaps set1: " + set2.Overlaps(set1));


    }
}