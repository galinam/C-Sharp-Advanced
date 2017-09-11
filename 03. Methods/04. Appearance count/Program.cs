using System;

class Program
{
    static int AppearanceCount(string[] numbers, int numX)
    {
       int result = 0;

       foreach (var num in numbers)
       {
           if (int.Parse(num) == numX)
           {
               result++;
           }
       }
       return result;
    }
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string numbs = Console.ReadLine();
        string[] numbers = numbs.Split(' ');

        int numX = int.Parse(Console.ReadLine());
        Console.WriteLine(AppearanceCount(numbers,numX));


    }
}