using System;

class Program
{
    static string ReverseNumber(string decimalNumber)
    {
        string result = "";

        for (int i = decimalNumber.Length - 1; i >= 0; i--)
        {
            result += decimalNumber[i];
        }

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(ReverseNumber(input));
    }
}