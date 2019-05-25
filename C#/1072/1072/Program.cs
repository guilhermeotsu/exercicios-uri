using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i = 0, fora=0, dentro=0;

            x = int.Parse(Console.ReadLine()); 

            for (i = 1; i <= x; i++)
            {
                y = int.Parse(Console.ReadLine()); 

                if (y >= 10 && y <= 20)
                {
                    dentro += 1;
                } else
                {
                    fora += 1;
                }
            }
            Console.WriteLine(dentro + " in\n" + fora + " out");
            Console.ReadLine();
        }
    }
}
