using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class StartUp
{
    static void Main()
    {
        string filePath = @"..\..\Text.txt";

        var writer = new StreamWriter(filePath);
        writer.Write(@"Two start households, both alike in dignity,
In fair Verona, where we lay our startscene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writer.Close();

        using (var reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                line = line.Replace("start", "finish");
                using (var writerRep = new StreamWriter(@"..\..\RepText.txt", true))
                {
                    writerRep.WriteLine(line);
                }
            }
        }
    }
}



/*
 *  using (var reader = new StreamReader(filePath))
        {
            string line;
            string wordToFind = "start";
            string replaceWith = "finish";
            int startInd = 0;
            int startIndWord = 0;
            while ((line = reader.ReadLine()) != null)
            {
                while (startInd < line.Length)
                {
                    if ((startIndWord = line.IndexOf(wordToFind, startInd)) >= 0)
                    {
                        line = line.Remove(startIndWord, wordToFind.Length);
                        line = line.Insert(startIndWord, replaceWith);
                    }
                    else break;
                    startInd = startIndWord + replaceWith.Length - 1;
                }
                

                using (var writerRep = new StreamWriter(@"..\..\RepText.txt", true))
                {
                    writerRep.WriteLine(line);
                }
            }
        }
 */
