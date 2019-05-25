using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            String[] num = Console.ReadLine().Split(' ');

             b = int.Parse(num[0]);
             a = int.Parse(num[1]);

            if (b % a == 0 || a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.ReadLine();

        }
    }
}
