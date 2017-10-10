using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static string DecimalToBynary(BigInteger value)
    {
        string result = "";
        do
        {
            BigInteger digit = value % 2;
            value /= 2;
            result = digit + result;

        } while (value > 0);

        return result;
    }

    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToBynary(number));
    }
}