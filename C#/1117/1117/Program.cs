using System;
using System.Globalization;

namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, med;

            a = double.Parse(Console.ReadLine());
            

            while (a < 0.0 || a > 10.0)
            {
                Console.WriteLine("nota invalida");
                a = double.Parse(Console.ReadLine());
            }

            b = double.Parse(Console.ReadLine());
            while (b < 0.0 || b > 10.0)
            {
                Console.WriteLine("nota invalida");
                b = double.Parse(Console.ReadLine());
            }

            med = (a + b) / 2.0;
            Console.WriteLine("media = " + med.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
