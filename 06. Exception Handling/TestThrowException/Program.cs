using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{

    public static double Sqrt(double value)
    {
        if (value < 0)
            throw new System.ArgumentOutOfRangeException(
               "Sqrt for negative numbers is undefined!");

        return Math.Sqrt(value);
    }
    static void Main()
    {
        //try
        //{
        //    Sqrt(-1);
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.Error.WriteLine("Error: " + ex.Message);
        //    throw;
        //}


        //try
        //{
        //    CauseFormatException();
        //}
        //catch (FormatException fe)
        //{
        //    Console.Error.WriteLine("Exception: {0}\n{1}", fe.Message, fe.StackTrace);

        //}

        try
        {
            int.Parse("99999999999999999999999999999999999999999999999999999999999999");
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Parse to int failed!");
            //throw fe; // Re-throw the caught exception
        }
        catch (OverflowException)
        {
            Console.WriteLine("To Big");
        }
    }
    //catch (FormatException)
    //{
    //    throw; // Re-throws the last caught exception
    //}


    public static void CauseFormatException()
    {
        string s = "an invalid number";
        int.Parse(s);
    }
}