using System;
using System.Globalization;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont, n1 = 0, n2; 
            double div;

            n = int.Parse(Console.ReadLine());

            for (cont = 1; cont <= n; cont++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                n1 = int.Parse(vet[0]);
                n2 = int.Parse(vet[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    div = (double)n1 / n2;
                    Console.WriteLine("" + div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
