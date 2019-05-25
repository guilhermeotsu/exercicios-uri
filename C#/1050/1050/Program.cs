using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i =0;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 8; i++)
            {
                if (n == 61)
                {
                    Console.WriteLine("Brasilia");
                }
                else if (n == 71)
                {
                    Console.WriteLine("Salvador");
                }
                else if (n == 11)
                {
                    Console.WriteLine("Sao Paulo");
                }
                else if (n == 21)
                {
                    Console.WriteLine("Rio de Janeiro");
                }
                else if (n == 32)
                {
                    Console.WriteLine("Juiz de Fora");
                }
                else if (n == 19)
                {
                    Console.WriteLine("Campinas");
                }
                else if (n == 27)
                {
                    Console.WriteLine("Vitoria");
                }
                else if (n == 31)
                {
                    Console.WriteLine("Belo Horizonte");
                }
                else
                {
                    Console.WriteLine("DDD nao cadastrado");
                }
                n = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
