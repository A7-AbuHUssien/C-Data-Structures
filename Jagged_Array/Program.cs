using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedarr = new int[3][];
        jaggedarr[0] = new int[] { 1, 3, 6 };
        jaggedarr[1] = new int[] { 2, 3, 6 };
        jaggedarr[2] = new int[] { 2, 3, 6, 9 };

        for (int i = 0; i < jaggedarr.Length; i++)
        {
            for (int j = 0; j < jaggedarr[i].Length; j++)
            {
                Console.Write(jaggedarr[i][j]+" ");
            }
            Console.WriteLine();
        }
    }
}

