using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, quad;

            n = int.Parse(Console.ReadLine()); 

            for(i = 1; i <=n; i++)
            {
                if(i % 2 == 0)
                {
                    quad = i * i;
                    Console.WriteLine(i + "^" + "2" + " = " + "" + quad);
                    
                }
            }
            Console.ReadLine();
        }
    }
}
