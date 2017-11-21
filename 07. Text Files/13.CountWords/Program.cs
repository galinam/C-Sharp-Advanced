// https://www.dotnetperls.com/dictionary
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter writerText = new StreamWriter(@"..\..\fileForScaning.txt");
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

        string[] words = File.ReadAllLines("../../words.txt");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        using (StreamReader reader = new StreamReader("../../fileForScaning.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    string regex = @"\b" + words[i] + @"\b";
                    MatchCollection matches = Regex.Matches(line, regex, RegexOptions.IgnoreCase);
                    if (dictionary.ContainsKey(words[i]))
                    {
                        dictionary[words[i]] += matches.Count;
                    }
                    else
                    {
                        dictionary.Add(words[i], matches.Count);
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter("../../result.txt"))
        {
            foreach (var wordCount in dictionary.OrderByDescending(key => key.Value))
            {
                writer.WriteLine("{0} - {1}", wordCount.Key, wordCount.Value);
            }
            Console.WriteLine("Count Complete - Please Check result.txt file!");
        }
    }
}
