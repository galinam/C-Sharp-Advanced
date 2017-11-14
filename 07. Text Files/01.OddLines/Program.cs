using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class StartUp
{
    static void Main()
    {
        var writer = new StreamWriter(@"..\..\OddLines.txt");
        writer.Write(@"Two households, both alike in dignity,
In fair Verona, where we lay our scene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writer.Close();

        using (var reader = new StreamReader(@"..\..\OddLines.txt"))
        {
            string line;
            int lineCounter = 1;
            while ((line = reader.ReadLine()) != null)
            {
                if (lineCounter % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                lineCounter++;
            }
        }
    }
}
