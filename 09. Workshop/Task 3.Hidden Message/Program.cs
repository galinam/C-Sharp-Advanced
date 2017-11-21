using System;
class Program
{
    static void Main()
    {
        string startIndexStr = Console.ReadLine();       
        string hiddenMessage = "";

        while (startIndexStr != "end")
        {
            int startIndex = int.Parse(startIndexStr);
            int stepS = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();

            if (startIndex < 0)
            {
                startIndex += message.Length;
            }
            for (; (startIndex < message.Length) && (startIndex >= 0); startIndex += stepS)
            {
                hiddenMessage += message[startIndex];
            }
            startIndexStr = Console.ReadLine(); 
        }
        Console.WriteLine(hiddenMessage);
    }
}