using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length;)
        {
            char valueP = input[i];

            if (valueP == '0')
            {
                Console.WriteLine("Too drunk to go on after {0}!", i);
                break;
            }
            if (valueP == '^')
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                break;
            }
            switch (valueP)
            {
                case '2': i += 2;
                    break;
                case '4': i += 4;
                    break;
                case '6': i += 6;
                    break;
                case '8': i += 8;
                    break;
                default:
                    break;
            }
            switch (valueP)
            {
                case '1': i -= 1;
                    break;  
                case '3': i -= 3;
                    break;  
                case '5': i -= 5;
                    break;  
                case '7': i -= 7;
                    break;  
                case '9': i -= 9;
                    break;
                default:
                    break;
            }
            if ((i >= input.Length) || (i < 0))
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", i);
                break;
            }

        }
    }
}