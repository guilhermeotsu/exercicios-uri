using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, qtdpos = 0, qtdne = 0, qtdimp = 0, qtdpar = 0;

            for(i=1; i<=5; i++)
            {
                num = int.Parse(Console.ReadLine());

               
                if (num > 0)
                {
                    qtdpos = qtdpos + 1; 
                } 
                if (num < 0)
                {
                    qtdne = qtdne + 1; 
                }

                if (num % 2 != 0)
                {
                    qtdimp = qtdimp + 1;
                }
                if (num % 2 == 0 || num ==0)
                {
                    qtdpar = qtdpar + 1; 
                }
               
            }
            Console.WriteLine(qtdpar + " valor(es) par(es)\n"
                             + qtdimp + " valor(es) impar(es)\n"
                             + qtdpos + " valor(es) positivo(s)\n"
                             + qtdne + " valor(es) negativo(s)");
            Console.ReadLine();
        }
    }
}
