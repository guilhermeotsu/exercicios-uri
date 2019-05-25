using System;
using System.Globalization;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, med;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            med = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0;

            Console.WriteLine("MEDIA = " + med.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine(); 

        }
    }
}
