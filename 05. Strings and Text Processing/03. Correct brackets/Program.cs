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
        int countFrontSlash = 0;
        int countBackSlash = 0;
        //int indexFS = 0;
        //int indexBS = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')  //(indexFS = input.IndexOf("(", indexFS)) >= 0
            {
                countFrontSlash++;
            }

            if (input[i] == ')')    //(indexBS = input.IndexOf(")", indexBS)) >= 0
            {
                countBackSlash++;
            }
        }

        if (countFrontSlash == countBackSlash)
        {
            Console.WriteLine("Correct");
        }
        else Console.WriteLine("Incorrect");
    }
}