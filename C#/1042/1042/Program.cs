using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3; 

            String[] numeros = Console.ReadLine().Split(' ');

            n1 = int.Parse(numeros[0]);
            n2 = int.Parse(numeros[1]);
            n3 = int.Parse(numeros[2]);

            if (n1 < n2 && n2 < n3)
            {
                Console.WriteLine(""+ n1 + "\n" + n2 + "\n" + n3); //n1, n2 n3
            }
            else if (n1 < n3 && n3 < n2){
                Console.WriteLine("" + n1 + "\n" + n3 + "\n" + n2); //n1, n3, n2
            }
            else if (n2 < n1 && n1 < n3)
            {
                Console.WriteLine("" + n2 +"\n" + n1 + "\n" + n3); //n2, n1, n3
            }
            else if (n2< n3 && n2< n1)
            {
                Console.WriteLine("" + n2 + "\n" + n3 + "\n" + n1); //n2, n3, n1
            }
            else if (n3 < n1 && n1 < n2)
            {
                Console.WriteLine("" + n3 + "\n" + n1 + "\n" + n2); 
            }
            else if (n3 < n2 && n2 < n1)
            {
                Console.WriteLine("" + n3 + "\n" + n2 + "\n" + n1);
            }

            Console.WriteLine("\n" + n1 + "\n" + n2 + "\n" + n3); 

            Console.ReadLine();
        }
    }
}
