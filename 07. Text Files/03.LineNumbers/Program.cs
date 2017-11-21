using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        var writer = new StreamWriter(@"..\..\Lines.txt");
        writer.Write(@"Two households, both alike in dignity,
In fair Verona, where we lay our scene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writer.Close();

        using (var reader = new StreamReader(@"..\..\Lines.txt"))
        {
            string line;
            int lineCounter = 1;
            bool appendToFile = true;
            while ((line = reader.ReadLine()) != null)
            {
                using (var writerNum = new StreamWriter(@"..\..\NumedLines.txt", appendToFile))
                {
                    writerNum.WriteLine("{0}: {1}", lineCounter, line);
                }
                lineCounter++;
            }
        }
    }
}
