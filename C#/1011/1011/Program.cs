using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, v;

            r = double.Parse(Console.ReadLine());

            v = (4 / 3.0) * 3.14159 * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = " + v.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
