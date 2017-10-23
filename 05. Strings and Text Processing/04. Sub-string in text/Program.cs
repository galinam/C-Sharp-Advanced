using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        int index = 0;
        int counter = 0;
        while ((index = text.IndexOf(pattern, index, StringComparison.CurrentCultureIgnoreCase)) >= 0)
        {
            counter++;
            index++;
        }

        Console.WriteLine(counter);
    }
}