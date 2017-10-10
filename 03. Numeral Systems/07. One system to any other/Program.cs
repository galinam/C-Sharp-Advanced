using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static BigInteger ConvertLowerToDecimal(string number, int numeralBase)
    {
        BigInteger result = 0;
        foreach (char digit in number)
        {
            result = result*numeralBase + (digit - '0');
        }

        return result;
    }

    static string ConvertDecimalToLower(BigInteger number, int numeralBase)
    {
        string result = "";
        do
        {
            BigInteger digit = number % numeralBase;
            number /= numeralBase;
            result = digit + result;

        } while (number > 0);

        return result;
    }

    static BigInteger ConvertBiggerToDecimal(string number, int numeralBase)
    {
        BigInteger result = 0;
        foreach (char digit in number)
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

            result = result * numeralBase + digitValue;
        }

        return result;
    }

    static string ConvertDecToBigger(BigInteger number, int numeralBase)
    {
        string result = "";
        string hexDigit = "0123456789ABCDEF";
        do
        {
            int digitValue = (int)(number % numeralBase);
            char digit = hexDigit[digitValue];
            number /= numeralBase;

            result = digit + result;

        } while (number > 0);

        return result;
    }
    

    static void Main()
    {
        int sBase = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        int dBase = int.Parse(Console.ReadLine());

        if ((sBase <= 10) & (dBase <= 10))
        {
            BigInteger result = ConvertLowerToDecimal(number, sBase);
            if (dBase == 10)
            {
                Console.WriteLine(result);
            }
            else Console.WriteLine(ConvertDecimalToLower(result, dBase));
        }
        else if ((sBase <= 10) & (dBase >= 10))
        {
            BigInteger result = ConvertLowerToDecimal(number, sBase);
            if (dBase == 10)
            {
                Console.WriteLine(result);
            }
            else Console.WriteLine(ConvertDecToBigger(result, dBase));
        }
        else if ((sBase >= 10) & (dBase <= 10))
        {
            BigInteger result = ConvertBiggerToDecimal(number, sBase);
            if (dBase == 10)
            {
                Console.WriteLine(result);
            }
            else Console.WriteLine(ConvertDecimalToLower(result, dBase));
        }
        else if ((sBase >= 10) & (dBase >= 10))
        {
            BigInteger result = ConvertBiggerToDecimal(number, sBase);
            if (dBase == 10)
            {
                Console.WriteLine(result);
            }
            else Console.WriteLine(ConvertDecToBigger(result, dBase));
        }
        
    }
}