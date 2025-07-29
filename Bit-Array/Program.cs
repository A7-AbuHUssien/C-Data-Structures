using System;
using System.Collections;

class Program
{
    static void Main()
    {
        BitArray bits1 = new BitArray(new[] { true, false, true, false });
        BitArray bits2 = new BitArray(new[] { true, true, true, false });

        Console.WriteLine("bits1: " + ToBinary(bits1));
        Console.WriteLine("bits2: " + ToBinary(bits2));
        Console.WriteLine("\n--- Bitwise Ops ---");

        Console.WriteLine("AND : " + ToBinary(new BitArray(bits1).And(bits2)));
        Console.WriteLine("OR  : " + ToBinary(new BitArray(bits1).Or(bits2)));
        Console.WriteLine("XOR : " + ToBinary(new BitArray(bits1).Xor(bits2)));
        Console.WriteLine("NOT : " + ToBinary(new BitArray(bits1).Not()));

        Console.ReadKey();
    }

    static string ToBinary(BitArray bits)
    {
        char[] chars = new char[bits.Length];
        for (int i = 0; i < bits.Length; i++)
            chars[i] = bits[i] ? '1' : '0';
        return new string(chars);
    }
}
