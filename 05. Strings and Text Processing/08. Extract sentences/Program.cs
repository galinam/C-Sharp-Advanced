using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;

        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string[] sentenceSeparators = { "." };
        char[] wordSeparators = { ',', '\n', '\t', '\v', ' ', '/', '\\', '|', '<', '>', '+', '=', '-', '_', ':', ';', '\"', '\'', '[', ']', '{', '}', '(', ')',
                                      '*', '&', '^', '%', '$', '#', '@', '~', '`', '!', '?', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\u20AC' };
        //text.Where(x => !char.IsLetter(x)).Distinct().ToArray(); //

        //var wordCapitalized = wordToFind.Replace(wordToFind[0], char.ToUpper(wordToFind[0]));
        //var wordNormalized = wordToFind.Replace(wordToFind[0], char.ToLower(wordToFind[0]));
                
        string[] sentences = (text.Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries));

        for (int i = 0; i < sentences.Length; i++)
        {
            string[] sentenceWords = sentences[i].Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < sentenceWords.Length; j++)
            {                
                if (sentenceWords[j].Trim().CompareTo(word) == 0)
                {
                    Console.Write(sentences[i].Trim() + ". ");
                    if (j == (sentences.Length - 1))
                    {
                        Console.Write(sentences[i].Trim() + ".");
                    }
                    break;
                }
            }

        }
    }
}