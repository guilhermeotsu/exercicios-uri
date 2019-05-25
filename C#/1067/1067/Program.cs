using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i;
            i = 0;

            x = int.Parse(Console.ReadLine());
            
            for (i = 1; i <= x; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
