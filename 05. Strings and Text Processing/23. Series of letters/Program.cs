using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        int startIndex;
        int endIndex;
        int length = 1;
        string subStr = "";

        for (int ch = 0; ch < inputStr.Length; ch++)
        {
            if (Char.IsLetter(inputStr[ch]))
            {
                endIndex = ch;

                if (((ch + 1) < inputStr.Length) && (inputStr[ch] == inputStr[ch + 1]))
                {
                    length++;
                }
                else
                {
                    startIndex = endIndex - length + 1;
                    subStr = inputStr.Substring(startIndex, length);
                    inputStr = inputStr.Remove(startIndex, length);
                    inputStr = inputStr.Insert(startIndex, subStr[0].ToString());


                    length = 1;
                    ch = startIndex;
                    continue;
                }
            }
        }
        Console.WriteLine(inputStr);
    }
}
