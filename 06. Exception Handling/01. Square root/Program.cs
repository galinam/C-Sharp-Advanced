using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{

    static double Sqrt(double value)
    {
        return Math.Sqrt(value);
    }
    static void Main()
    {
        try
        {
            double value = double.Parse(Console.ReadLine());
            if (value < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else Console.WriteLine("{0:f3}", Sqrt(value));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        //catch(OverflowException)
        //{
        //    Console.WriteLine("Value is too big");
        //}
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}