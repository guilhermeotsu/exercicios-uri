using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, nota100, nota50, nota20, nota10, nota5, nota2,
                      resto100, resto50, resto20, resto10, resto5, resto2,
                      moeda1, moeda050, moeda025, moeda010, moeda005, moeda001,
                      resto1, resto050, resto035, resto010, resto005;

            n = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            nota100 = (int)n / 100;
            resto100 = nota100 % 100;

            nota50 = (int)resto100 / 50;
            resto50 = nota50 % 50;

            nota20 = (int)resto50 / 20;
            resto20 = nota20 % 20;

            nota10 = (int)resto20 / 10;
            resto10 = nota10 % 10;

            nota5 = (int)resto10 / 5;
            resto5 = nota5 % 5;

            nota2 = (int)resto5 / 2;
            resto2 = nota2 % 2;

            moeda1 = (int)resto2 / 1;

            moeda050 = (int)moeda1 / 0.5;

            moeda025 = (int)moeda050 / 25;
            moeda010 = (int)moeda025 / 10;
            moeda005 = (int)moeda010 / 5;
            moeda001 = (int)moeda005 / 1;

         
            Console.WriteLine("NOTAS:\n" + nota100 + " nota (s) de R$ 100.00\n"
                              + nota50 + " nota(s) de R$ 50.00\n"
                              + nota20 + " nota (s) de R$ 20.00\n"
                              + nota10 + " nota(s) de R$ 10.00\n"
                              + nota5 + " nota (s) de R$ 5.00\n"
                              + nota2 + " nota (s) de R$ 2.00\n");
            Console.WriteLine("MOEDAS:\n" + moeda1 + " moeda (s) de R$ 1.00\n"
                              + moeda050 + " moeda (s) de R$ 0.50\n"
                              + moeda025 + " moeda (s) de R$ 0.25\n"
                              + moeda010 + " moeda (s) de R$ 0.10\n"
                              + moeda005 + " moeda (s) de R$ 0.05\n"
                              + moeda001 + " moeda (s) de R$ 0.01\n");

            Console.ReadLine();
        }
        
    }
}
