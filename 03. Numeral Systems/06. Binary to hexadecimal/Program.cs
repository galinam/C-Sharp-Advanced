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

    static string DecToHex(BigInteger value)
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

    static string BinaryToHex(string value)
    {
        BigInteger decimalNum = BinaryToDecimal(value);
        string result = DecToHex(decimalNum);

        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(BinaryToHex(number));
    }
}