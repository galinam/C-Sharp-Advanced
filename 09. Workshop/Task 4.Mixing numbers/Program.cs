using System;
class Program
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numN];
        int[] mixingNumbers = new int[numN - 1];
        int[] subtractingNumbers = new int[numN - 1];

        for (int i = 0; i < numN; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int firstNumDigit = numbers[i] % 10;
            int nextNumDigit = numbers[i+1] / 10;
            mixingNumbers[i] = firstNumDigit * nextNumDigit;
            subtractingNumbers[i] = Math.Abs(numbers[i] - numbers[i + 1]);
        }
        Console.WriteLine(String.Join(" ", mixingNumbers));
        Console.WriteLine(String.Join(" ", subtractingNumbers));
    }
}
