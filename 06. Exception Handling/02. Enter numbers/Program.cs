using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    public const int START = 1;
    public const int END = 100;

    static int EnterNumber(int start, int end)
    {
        int result = int.Parse(Console.ReadLine());
        return result;
    }

    static bool IsOrderedSeq(int[] numbers)
    {
        bool result = true;
        int num1;
        int num2;
        num1 = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            num2 = numbers[i];

            if (num1 < num2)
            {
                num1 = num2;
                //continue;
            }
            else
            {
                result = false;
                //throw new ArgumentException();
            }
        }
        return result;
    }

    static void Main()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = EnterNumber(START, END);
        }

        try
        {
            //if (numbers.Any(x => x < START) || numbers.Any(x => x > END) || !IsOrderedSeq(numbers))
            //{
            //    throw new ArgumentException();
            //}
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] < START) || (numbers[i] > END) || !IsOrderedSeq(numbers))
                {
                    throw new ArgumentException();
                }
            }

            Console.WriteLine("1 < " + string.Join(" < ", numbers) + " < 100");
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Exception");
        }
    }
}