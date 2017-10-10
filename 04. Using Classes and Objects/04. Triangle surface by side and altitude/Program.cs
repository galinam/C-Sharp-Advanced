using System;
using System.Globalization;
using System.Threading;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Program
    {
        static decimal TriangleSurface(decimal side, decimal altitude)
        {
            decimal surface;
            surface = (side * altitude) /2;

            return surface;
        }
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

            decimal side = decimal.Parse(Console.ReadLine());
            decimal altitude = decimal.Parse(Console.ReadLine());

            decimal surface = TriangleSurface(side, altitude);

            Console.WriteLine("{0:f2}", surface);
        }
    }
}
