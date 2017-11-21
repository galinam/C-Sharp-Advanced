using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class StartUp
{
    static void Main()
    {
        string filePath = @"..\..\text.txt";
        StreamWriter writer = new StreamWriter(filePath);
        writer.Write(@"Two start households, both alike in dignity,
In fair Verona, where we lay our startscene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writer.Close();

        string[] allLines = File.ReadAllLines(filePath);

        using (var writerDel = new StreamWriter(filePath))
        {
            for (int i = 0; i < allLines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    writerDel.WriteLine(allLines[i]);
                }
            }
        }
    }
}