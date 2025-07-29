using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


        // A ∪ B
        set1.UnionWith(set2);

        // A ∩ B
        set1.IntersectWith(set2);

        // A − B
        set1.ExceptWith(set2);

        // (A − B) ∪ (B − A)
        set1.SymmetricExceptWith(set2);


        // Test => Dont forget to comment out the other Operation
        Console.WriteLine("(A − B) ∪ (B − A):");
        foreach (int item in set1)
        {
            Console.WriteLine(item);
        }
    }
}
