using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitted = input.Split(new[] { "<a href=\"", "</a>" }, StringSplitOptions.None);
        for (int i = 1; i < splitted.Length; i += 2)
        {
            int index = splitted[i].IndexOf("\">");
            string url = splitted[i].Substring(0, index);
            string text = splitted[i].Substring(index + 2, splitted[i].Length - index - 2);
            splitted[i] = String.Format("[{0}]({1})", text, url);
        }
        Console.WriteLine(string.Join(string.Empty, splitted));

    }
}