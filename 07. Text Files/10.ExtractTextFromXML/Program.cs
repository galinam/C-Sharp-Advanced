using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"..\..\text.txt";

        string text = File.ReadAllText(filePath);
        string startTag = ">";
        string endTag = "</";

        for (int i = 0; i < text.Length; i++)
        {
            if (i < text.Length - 1 && text[i] == '>' && text[i + 1] != '<')
            {
                int startingIndex = i + 1;
                int wordLength = 0;
                while (text[i] != '<')
                {
                    wordLength++;
                    i++;
                }
                using (var writer = new StreamWriter(@"..\..\textOUT.txt", true))
                {
                    writer.WriteLine(text.Substring(startingIndex, wordLength - 1));
                }
            }

        }
    }
}