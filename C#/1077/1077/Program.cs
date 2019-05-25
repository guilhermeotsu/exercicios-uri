using System;

namespace _1077
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet = new int[1001];

            n = int.Parse(Console.ReadLine()); 

            for(int i = 0; i <= 1000; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    vet[i] = j;
                    Console.WriteLine($"N[{i}] = " + vet[i]);
                    i++;
                }
                i -= 1;
            }
        }
    }
}
