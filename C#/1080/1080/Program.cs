using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, i = 0, maior = 0, casa = 0; 

            for(i = 1; i <= 100; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n >= maior)
                {
                    maior = n;
                    casa = i; 
                } 
            }
            Console.WriteLine(maior + "\n" + casa);
            Console.ReadLine();
        }
    }
}
