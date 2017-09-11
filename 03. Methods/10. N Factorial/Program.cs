using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{

    static BigInteger CalculateNFakturial(int[] array)
    {
        BigInteger result = 1;     
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }

        return result;
    }
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] arrayOfNUmbers = new int[numberN];

        for (int i = 0; i < numberN; i++)
        {
            arrayOfNUmbers[i] = i + 1;
        }
        if (numberN == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(CalculateNFakturial(arrayOfNUmbers));
        }
    }
}