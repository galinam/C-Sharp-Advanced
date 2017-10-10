using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class Program
    {
        static double TriangleSurface(double sideA, double sideB, double angle)
        {
            double result;
            angle = Math.PI * angle / 180.0;
            result = (sideA * sideB * Math.Sin(angle))/2;

            return result;
        }

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

            double sideOne = double.Parse(Console.ReadLine());
            double sideTwo = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", TriangleSurface(sideOne, sideTwo, angle));
        }
    }
}
