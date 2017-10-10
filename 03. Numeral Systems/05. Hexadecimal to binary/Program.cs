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

    static string DecimalToBinary(BigInteger value)
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

    static string ConvertHexToBinary(string value)
    {
        BigInteger decimalNum = ConvertHexToDec(value);
        string result = DecimalToBinary(decimalNum);

        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(ConvertHexToBinary(number));
    }
}