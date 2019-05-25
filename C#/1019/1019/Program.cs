using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, oras, oras1, min, seg;

            t = int.Parse(Console.ReadLine());

            oras = t / 3600;
            oras1 = t % 3600; 
            min = oras1 / 60;
            seg = oras1 % 60;

            Console.WriteLine(oras + ":" + min + ":" + seg);

            Console.ReadLine(); 
        }
    }
}
