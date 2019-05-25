using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int orai, oraf, mini, minf, x = 60;

            string[] vet = Console.ReadLine().Split(' ');

            orai = int.Parse(vet[0]);
            oraf = int.Parse(vet[1]);
            mini = int.Parse(vet[2]);
            minf = int.Parse(vet[3]); 

            if (orai > oraf)
            {
                x = x - orai 
            }
        }
    }
}
