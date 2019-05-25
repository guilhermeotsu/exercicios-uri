using System;
using System.Globalization;
namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, total;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = salario + (vendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
