using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        var writerOne = new StreamWriter(@"..\..\FileTextOne.txt");
        writerOne.Write(@"Two households, both alike in dignity,
In fair Verona, where we lay our scene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writerOne.Close();

        var writerTwo = new StreamWriter(@"..\..\FileTextTwo.txt");
        writerTwo.Write(@"Two households, both alike in dignity,
In fair Verona, where we lay our scene,
From ancient grudge break to new mutiny, new mutiny
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life; their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writerTwo.Close();

        int counterSameLines = 0;
        int counterDiffLines = 0;
        using (var readerOne = new StreamReader(@"..\..\FileTextOne.txt"))
        using (var readerTwo = new StreamReader(@"..\..\FileTextTwo.txt"))
        {
            string lineFileTextOne;
            string lineFileTextTwo;
            while (((lineFileTextOne = readerOne.ReadLine()) != null) && ((lineFileTextTwo = readerTwo.ReadLine()) != null))
            {
                if (lineFileTextOne.CompareTo(lineFileTextTwo) == 0)
                {
                    counterSameLines++;
                }
                else counterDiffLines++;
            }
        }
        Console.WriteLine("Same lines: {0}\nDifferent lines: {1}", counterSameLines, counterDiffLines);
    }
}