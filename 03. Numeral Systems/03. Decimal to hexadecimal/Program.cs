using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static string ConvertDecToHex(BigInteger value)
    {
        string result = "";
        string hexDigit = "0123456789ABCDEF";
        do
        {
            int digitValue = (int)(value % 16);
            char digit = hexDigit[digitValue];
            value /= 16;

            result = digit + result;

        } while (value > 0);

        return result;
    }
    static void Main()
    {
        BigInteger value = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(ConvertDecToHex(value));
    }
}