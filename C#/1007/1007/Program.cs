using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, dif;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            dif = a * b - c * d;

            Console.WriteLine("DIFERENCA = " + dif);

            Console.ReadLine();


        }
    }
}
