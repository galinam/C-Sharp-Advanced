using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();

        foreach (var ch in charArray)
        {
            Console.Write("\\u" + ((int)ch).ToString("X4"));
        }
    }
}