using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var writerOne = new StreamWriter(@"..\..\FileOne.txt");
        writerOne.Write(@"Two households, both alike in dignity,
In fair Verona, where we lay our scene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.");
        writerOne.Close();

        var writerTwo = new StreamWriter(@"..\..\FileTwo.txt");
        writerTwo.Write(@"A programming language is a formal language that specifies a set of instructions that can be used to produce various kinds of output.
Programming languages generally consist of instructions for a computer.
Programming languages can be used to create programs that implement specific algorithms.");
        writerTwo.Close();

        string fileOneContent = File.ReadAllText(@"..\..\FileOne.txt");  //Read all content of givven text file - two ways
        string fileTwoContent;                                           //or
        using (var reader = new StreamReader(@"..\..\FileTwo.txt"))
        {
            fileTwoContent = reader.ReadToEnd();
        }

        using (StreamWriter writer = File.CreateText(@"..\..\ConcatenateText.txt"))    //is equals to new StreamWriter(@"..\..\ConcatenateText.txt")
        {
            //writer.Write(String.Format(fileOneContent + Environment.NewLine + fileTwoContent));
            File.AppendAllText(@"..\..\ConcatenateText.txt", String.Format("{0}{1}{2}", fileOneContent, Environment.NewLine, fileTwoContent));
        }
    }
}
