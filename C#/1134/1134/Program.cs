using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, um = 0, dois = 0, tres = 0;

            do
            {
                n = int.Parse(Console.ReadLine());

                if (n > 4)
                {
                    n = int.Parse(Console.ReadLine());
                }
                if (n == 1)
                {
                    um++;
                }
                else if (n == 2)
                {
                    dois++;
                }
                else if (n == 3)
                {
                    tres++;
                }
            } while (n != 4);
            Console.WriteLine("MUITO OBRIGADO" +
                                "\nAlcool: " + um +
                                "\nGasolina: " + dois +
                                "\nDiesel: " + tres);
            Console.ReadLine();
        }
    }
}
