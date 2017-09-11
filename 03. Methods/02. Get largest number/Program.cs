using System;

class Program
{
    static int GetMax(int a, int b)
    {
        int result = a;
        if (a < b)
        {
            result = b;
        }
        return result;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int maxNum = GetMax(int.Parse(numbers[0]), int.Parse(numbers[1]));
        Console.WriteLine(GetMax(maxNum, int.Parse(numbers[2])));
    }
}
