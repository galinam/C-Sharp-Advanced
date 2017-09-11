using System;

class Program
{
    static bool LargeThanNeighbours(string[] numbers, int indexOfElement)
    {
        bool largest = false;

        if ((int.Parse(numbers[indexOfElement - 1]) < int.Parse(numbers[indexOfElement])) && (int.Parse(numbers[indexOfElement + 1]) < int.Parse(numbers[indexOfElement])))
        {
            largest = true;
        }

        return largest;
    }
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        string numbs = Console.ReadLine();
        string[] numbers = numbs.Split(' ');

        int target = -1;
        for (int i = 1; i < size - 1; i++)
        {
            if (LargeThanNeighbours(numbers, i))
            {
                target = i;
                break;
            }
        }

        Console.WriteLine(target);
    }
}