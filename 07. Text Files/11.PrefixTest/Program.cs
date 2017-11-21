using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = @"..\..\test.txt";
        StreamWriter writer = new StreamWriter(filePath);
        writer.Write(@"Two test households, both alike in dignity,
In fair Verona, where we lay our testscene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writer.Close();

        string fileContent = File.ReadAllText(filePath);
        File.WriteAllText("../../test.txt", Regex.Replace(fileContent, @"\b(test\w*)\b", String.Empty));
    }
}
