using System;
using System.Collections.Generic;
using System.Numerics;
class Program
{
    static BigInteger ConvertHexToDec(string value)
    {
        BigInteger result = 0;
        foreach (char digit in value)
        {
            int digitValue;
            if (char.IsDigit(digit))
            {
                digitValue = digit - '0';
            }
            else
            {
                digitValue = digit - 'A' + 10;
            }

            result = result * 16 + digitValue;
        }

        return result;
    }

    static void Main()
    {
        string value = Console.ReadLine();

        Console.WriteLine(ConvertHexToDec(value));
    }
}
