using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, cont;

            x = int.Parse(Console.ReadLine());
            y = x + 12;

            for(cont = x; cont <= y; cont ++)
            {
                if (cont % 2 != 0)
                {
                    Console.WriteLine(cont);
                }
            }
            Console.ReadLine();
        }
    }
}
