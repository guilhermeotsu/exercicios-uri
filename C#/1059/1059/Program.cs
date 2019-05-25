using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1059
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 2; 

            for(cont = 2; cont <= 100; cont++)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
            }
            Console.ReadLine();
        }
    }
}
