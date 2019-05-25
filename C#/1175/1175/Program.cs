using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[4];
            int n;

            for(int i = 4; i >= 0; i--)
            {
                n = int.Parse(vet[i]);
                for(int k = 0; k < 4; k++)
                {
                    Console.WriteLine($"N[{k}] = {vet[i]}\n");
                }
            }

        }
    }
}
