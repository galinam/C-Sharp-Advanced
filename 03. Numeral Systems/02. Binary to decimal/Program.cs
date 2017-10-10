using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static BigInteger BinaryToDecimal(string number)
    {
        BigInteger result = 0;
        foreach (char digit in number)
        {
            result = result * 2 + (digit - '0');
        }

        return result;
    }
    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(BinaryToDecimal(number));
    }
}