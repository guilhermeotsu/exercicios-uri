using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, num, qtd;

            cont = 0; num = 0; qtd = 0; 

            for(cont = 1; cont <= 5; cont++)
            {
                num = int.Parse(Console.ReadLine());
                if(num % 2 == 0)
                {
                    qtd += 1;
                }
            }
            Console.WriteLine(qtd + " valores pares");
            Console.ReadLine();

        }
    }
}
