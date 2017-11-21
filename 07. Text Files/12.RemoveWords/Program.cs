//http://dobromirivanov.net/c2-csharp-07-textfiles/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class Program
{
    static void Main()
    {
        StreamWriter writerText = new StreamWriter(@"..\..\text.txt");
        writerText.Write(@"Two test households, both alike in dignity,
In fair Verona, where we lay our testscene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair to to of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writerText.Close();

        StreamWriter writerWords = new StreamWriter(@"..\..\words.txt");
        writerWords.Write(@"in
to
we
do");
        writerWords.Close();

        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";
            string fileContent = File.ReadAllText("../../text.txt");
            File.WriteAllText("../../ClearedText.txt", Regex.Replace(fileContent, regex, String.Empty, RegexOptions.IgnoreCase));
            Console.WriteLine("Replace Complete!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found!");
        }
        catch (IOException)
        {
            Console.WriteLine("Input/Output Error!");
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("File Access Error!");
        }
    }
}