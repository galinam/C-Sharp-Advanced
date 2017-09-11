using System;
using System.Collections.Generic;
using System.Numerics;
class Program
{
    static int MinValue(int[] numArr)
    {
        int result = int.MaxValue;
        foreach (var num in numArr)
        {
            if (result > num)
            {
                result = num;
            }
        }
        return result;
    }

    static int MaxValue(int[] numArr)
    {
        int result = int.MinValue;
        foreach (var num in numArr)
        {
            if (result < num)
            {
                result = num;
            }
        }
        return result;
    }

    static double AvrValue(int[] numArr)
    {
        double result = 0.00;
        foreach (var num in numArr)
        {
            result += num;
        }
        result = result / numArr.Length;
        return result;
    }

    static int SumValue(int[] numArr)
    {
        int result = 0;
        foreach (var num in numArr)
        {
            result += num;
        }
        return result;
    }

    static BigInteger ProductValue(int[] numArr)
    {
        BigInteger result = 1;
        foreach (var num in numArr)
        {
            result *= num;
        }
        return result;
    }
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int[] numbersArr = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbersArr[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine(MinValue(numbersArr));
        Console.WriteLine(MaxValue(numbersArr));
        Console.WriteLine("{0:f2}",AvrValue(numbersArr));
        Console.WriteLine(SumValue(numbersArr));
        Console.WriteLine(ProductValue(numbersArr));
    }
}