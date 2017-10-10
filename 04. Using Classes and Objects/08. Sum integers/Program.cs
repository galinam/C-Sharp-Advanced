using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int SumNumbersFromArray(string[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += int.Parse(array[i]);
        }

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        string[] numbers = (input.Split(' ').ToArray());

        Console.WriteLine(SumNumbersFromArray(numbers));
    }
}
