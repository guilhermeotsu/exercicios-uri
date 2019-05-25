using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, num = 1;

            n = int.Parse(Console.ReadLine());

            while(i <= n)
            {
                Console.Write(num + " ");
                num++;
                Console.Write(num + " ");
                num++;
                Console.Write(num + " PUM\n");

                num+=2;

                i++;
            }
            Console.ReadLine();
        }
    }
}
