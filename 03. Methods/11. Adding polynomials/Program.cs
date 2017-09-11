using System;
using System.Collections.Generic;
class Program
{
    static int[] AddPolynomCoefToArray(string polynom)
    {
        string[] polynomArr = polynom.Split(' ');
        int[] polynomCoef = new int[polynomArr.Length];
        for (int i = 0; i < polynomArr.Length; i++)
        {
            polynomCoef[i] = int.Parse(polynomArr[i]);
        }

        return polynomCoef;
    }

    static int[] SumTwoPolynomialsCoef(int[] polynomCoef1, int[] polynomCoef2)
    {
        int[] sumOfPolynomialsCoef = new int[polynomCoef1.Length];
        for (int i = 0; i < polynomCoef1.Length; i++)
        {
            sumOfPolynomialsCoef[i] = polynomCoef1[i] + polynomCoef2[i]; 
        }

        return sumOfPolynomialsCoef;
    }


    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string firstPolynom = Console.ReadLine();
        string secondPolynom = Console.ReadLine();

        Console.WriteLine(String.Join(" ", SumTwoPolynomialsCoef(AddPolynomCoefToArray(firstPolynom), AddPolynomCoefToArray(secondPolynom))));
    }
}