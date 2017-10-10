using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
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

    static void Main()
    {
        string input = Console.ReadLine();
        BigInteger inputDec;
        string result;
        if (input[0] == '-')
        {
            input = input.Substring(1, input.Length - 1);
            //Console.WriteLine(input);
            inputDec = BigInteger.Parse(input);

            char[] binaryNum = DecimalToBinary(inputDec).PadLeft(16, '0').ToCharArray();
            for (int i = 0; i < binaryNum.Length; i++)
            {
                if (binaryNum[i] == '0')
                {
                    binaryNum[i] = '1';
                }
                else if (binaryNum[i] == '1')
                {
                    binaryNum[i] = '0';
                }
            }

            result = String.Join("", binaryNum);
            int number_one = Convert.ToInt32(result, 2);
            int number_two = Convert.ToInt32("1", 2);

            result = Convert.ToString(number_one + number_two, 2);
            Console.WriteLine(result);
        }
        else
        {
            inputDec = BigInteger.Parse(input);
            result = DecimalToBinary(inputDec).PadLeft(16, '0');
            Console.WriteLine(result);

        }
    }
}