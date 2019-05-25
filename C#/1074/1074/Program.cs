using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, x;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x > 0 && x % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (x > 0 && x % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x < 0 && x % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (x < 0 && x % 2 ==0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                
            }
            Console.ReadLine();
        }
    }
}

