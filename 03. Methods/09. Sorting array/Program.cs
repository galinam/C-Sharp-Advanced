using System;
using System.Collections.Generic;
class Program
{
    static int MaxNum(List<int> numArray)
    {
        int result = int.MinValue;
        int index = 0;
        for (int i = 0; i < numArray.Count; i++)
        {
            if (result < numArray[i])
            {
                result = numArray[i];
                index = i;
            }
        }

            RemoveElementFromArr(numArray, index);

        return result;
    }

    static List<int> RemoveElementFromArr(List<int> numArray, int index)
    {
        numArray.RemoveAt(index);
        return numArray;
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(' ');
        List<int> numArray = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            numArray.Add(int.Parse(numbers[i]));
        }

        int[] sortedArray = new int[size];

        for (int i = size - 1; i >= 0; i--)
        {
            sortedArray[i] = MaxNum(numArray);
        }

        Console.WriteLine(String.Join(" ", sortedArray));
    }
}