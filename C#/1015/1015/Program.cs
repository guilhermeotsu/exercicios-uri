using System;
using System.Globalization;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, dist;

            x1 = double.Parse(Console.ReadLine()); 
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            dist = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.WriteLine(dist.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
