using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j;

            for (j = 60; j >= 0; j -= 5)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                i += 3;
            }
            Console.ReadLine();
        }
    }
}
