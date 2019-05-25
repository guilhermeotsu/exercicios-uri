using System;
using System.Globalization;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, med;
            int opc;

            do
            {
                do
                {
                    a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (a < 0 || a > 10.0)
                    {
                        Console.WriteLine("nota invalida");           
                    }
                } while (a < 0 || a > 10.0);
                do
                {
                    b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (b < 0 || b > 10.0)
                    {
                        Console.WriteLine("nota invalida");                       
                    }
                } while (b < 0 || b > 10.0);

                med = (a + b) / 2.0;
                Console.WriteLine("media = " + med.ToString("F2", CultureInfo.InvariantCulture));

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opc = int.Parse(Console.ReadLine());
                    if (opc > 2 || opc < 1)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        opc = int.Parse(Console.ReadLine());
                    }
                } while (opc < 1 || opc > 2);
            } while (opc == 1);
            Console.ReadLine();
          
        }
    }
}
