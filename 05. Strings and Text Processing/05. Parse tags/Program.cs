using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        byte[] inputBuffer = new byte[10000];
        Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

        string text = Console.ReadLine();
        //string text = "</upcase>blank<upcase></upcase>full<upcase>up</upcase>doubleopen<upcase><upcase>a</upcase>doubleclose<upcase>b</upcase></upcase><upcase>";

        /*string text = Console.ReadLine(); Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
         */

        string startTag = "<upcase>";
        string endTag = "</upcase>";
        StringBuilder sb = new StringBuilder(text.Length);

        int startIndex = 0;
        int endIndex = 0;

        sb.Append(text);

        while ((startIndex = text.IndexOf(startTag, startIndex)) >= 0 && (endIndex = text.IndexOf(endTag, endIndex)) >= 0)
        {
            startIndex += startTag.Length;
            if (endIndex != startIndex && (endIndex - startIndex) > 0)
            {
                string subString = text.Substring(startIndex, endIndex - startIndex);
                subString = subString.ToUpper();
                sb.Remove(startIndex, endIndex - startIndex);
                sb.Insert(startIndex, subString);
                
            }

            endIndex += endTag.Length;
            startIndex = endIndex;
        }

        text = sb.ToString();
        //sb.Replace(startTag, "");
        //sb.Replace(endTag, "");

        startIndex = 0;
        endIndex = 0;
        while ((startIndex = text.IndexOf(startTag, 0)) >= 0 && (startIndex + startTag.Length) <= text.Length)
        {
            text = text.Remove(startIndex, startTag.Length);
        }
        while ((endIndex = text.IndexOf(endTag, 0)) >= 0 && (endIndex + endTag.Length) <= text.Length)
        {
            text = text.Remove(endIndex, endTag.Length);
        }

        Console.WriteLine(text);
    }
}