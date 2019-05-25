using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, oras;
            double salario, total;

            num = int.Parse(Console.ReadLine());
            oras = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            total = oras * salario;

            Console.WriteLine("NUMBER = " + num + "\nSALARY = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine(); 

        }
    }
}
