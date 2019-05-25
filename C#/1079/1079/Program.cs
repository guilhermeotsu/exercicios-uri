using System;
using System.Globalization;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i, med, n1 = 0, n2 = 0, n3=0;

            n = double.Parse(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                med = (2.0 * n1 + 3.0 * n2 + 5.0 * n3) / 10.0;
                Console.WriteLine(med.ToString("F1", CultureInfo.InvariantCulture));
            }
            
            Console.ReadLine();
        }
    }
}
