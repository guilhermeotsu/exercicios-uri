using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, res;

            i = 0;

            x = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                res = i * x;
                Console.WriteLine(i + " x " + x + " = " + res);
            }
            Console.ReadLine();
        }
    }
}
