using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, i, impar = 0;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                
                for(int j = x - 1; x <= y; x++)
                {
                    if(x % 2 != 0)
                    {
                        impar += x;
                        Console.Write(impar);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
