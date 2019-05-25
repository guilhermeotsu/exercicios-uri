using System;
using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, reaj = 0, sal = 0, perc = 0;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x >= 0 && x <= 400.00)
            {
                reaj = x * 0.15;
                sal = x + reaj;
                perc = 15;
            }
            else if (x >= 400.01 && x <= 800.00)
            {
                reaj = x * 0.12;
                sal = x + reaj;
                perc = 12;
            }
            else if (x >= 800.01 && x <= 1200.00)
            {
                reaj = x * 0.10;
                sal = x + reaj;
                perc = 10;
            }
            else if (x >= 1200.01 && x <= 2000.00)
            {
                reaj = x * 0.07;
                sal = x + reaj;
                perc = 7;
            }
            else if (x > 2000.00){
                reaj = x * 0.04;
                sal = x + reaj;
                perc = 4;
            }
            Console.WriteLine("Novo salario: " + sal.ToString("F2", CultureInfo.InvariantCulture)
                            + "\nReajuste ganho: " + reaj.ToString("F2", CultureInfo.InvariantCulture) 
                            + "\nEm percentual: " + perc + " %");
            Console.ReadLine();
        }
    }
}
