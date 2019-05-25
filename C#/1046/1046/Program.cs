using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f, x = 24;

             string[] vet = Console.ReadLine().Split(' ');

            i = int.Parse(vet[0]);
            f = int.Parse(vet[1]);
            
            if(i > f)
            {
                x = x - i + f;
                Console.WriteLine("O JOGO DUROU " + x + " HORA(S)");
            }
            else if (i < f)
            {
                x = f - x + x - i;
                Console.WriteLine("O JOGO DUROU " + x + " HORA(S)");
            }
            else //if (i == 0 && f == 0)
            {
                Console.WriteLine("O JOGO DUROU " + x + " HORA(S)");
            }
            Console.ReadLine();
        }
    }
}
