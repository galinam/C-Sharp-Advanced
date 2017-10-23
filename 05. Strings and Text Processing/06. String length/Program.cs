using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //byte[] inputBuffer = new byte[20];
        //Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        //Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder(20);
        sb.Append(input);

        if (input.Length < 20)
        {
            for (int i = 0; i < 20 - input.Length; i++)
            {
                sb.Append('*');
            }
        }
        Console.WriteLine(sb);
    }
}