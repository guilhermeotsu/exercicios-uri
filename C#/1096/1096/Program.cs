using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 7;

            for (i=1; i <=9; i += 2)
            {
                for (j = 7; j >= 5; j-= 1)
                {
                    Console.WriteLine("I=" + i + (" J=" + j));
                }
            }
            Console.ReadLine();
        }
    }
}
