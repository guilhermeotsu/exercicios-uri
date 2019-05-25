using System;

namespace _1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n = 0, sum = 0;
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

            while (n <= 0)
            {            
                n = int.Parse(vet[1]);
            }

            for (int i = 0; i < n; i++)
            {
                sum = a + i;
            }

            sum += a;

            Console.WriteLine(sum);
        }
    }
}
