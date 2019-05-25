using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + i + " " + i);
                Console.WriteLine(i + " " + i + " " + i);
            }
            Console.ReadLine();
        }
    }
}
