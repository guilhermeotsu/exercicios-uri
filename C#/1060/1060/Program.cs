using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,  qtd = 0;
            float num;
            i = 0; 

            for(i = 1; i <=6; i++)
            {
                num = float.Parse(Console.ReadLine());

                if(num > 0)
                {
                    qtd += 1;
                }
            }
            Console.WriteLine(qtd + " valores positivos");
            Console.ReadLine();
        }
    }
}
