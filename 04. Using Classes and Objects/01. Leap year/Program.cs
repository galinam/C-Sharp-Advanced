﻿using System;

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year) == true)
        {
            Console.WriteLine("Leap");
        }
        else Console.WriteLine("Common");
    }
}