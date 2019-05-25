using System;
using System.Globalization;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, imp = 0;

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n >= 0.0 && n <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            
            else if (n <= 3000.00)
            {
                imp = (n - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n <= 4500.00)
            {
                imp = (n - 3000.00) * 0.18 + (1000 * 0.08);
                Console.WriteLine("R$ " + imp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imp = (n - 4500.00) * 0.28 + (1500.00 * 0.18) + (1000 * 0.08);
                Console.WriteLine("R$ " + imp.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
