using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double result = 0;

        int digit3 = number % 10;
        number /= 10;
        int digit2 = number % 10;
        number /= 10;
        int digit1 = number % 10;

        switch (digit3)
        {
            case 0: result = (double)digit1 * digit2;
                break;
            case 1:
            case 2:
            case 3:
            case 4:
            case 5: result = (double)(digit1 * digit2) / (double)digit3;
                break;
            case 6:
            case 7:
            case 8:
            case 9: result = (double)(digit1 + digit2) * (double)digit3;
                break;
            default:
                break;
        }
        Console.WriteLine("{0:f2}", result);
    }
}