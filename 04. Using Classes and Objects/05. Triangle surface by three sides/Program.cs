using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static double TriangleSemiPerimeter(double sideA, double sideB, double sideC)
    {
        double result;
        result = (sideA + sideB + sideC) / 2;

        return result;
    }

    static double TriangleSurface(double sideA, double sideB, double sideC)
    {
        double result;
        double semiPerimeter = TriangleSemiPerimeter(sideA, sideB, sideC);

        result = Math.Sqrt(semiPerimeter*(semiPerimeter - sideA)*(semiPerimeter -  sideB)*(semiPerimeter -  sideC));

        return result;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        double sideOne = double.Parse(Console.ReadLine());
        double sideTwo = double.Parse(Console.ReadLine());
        double sideThree = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:f2}", TriangleSurface(sideOne, sideTwo, sideThree));

    }
}