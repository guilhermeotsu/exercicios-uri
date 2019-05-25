using System;

namespace _1177
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet = new int[1000];

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vet[i] = j;
                    Console.WriteLine($"N[{i}] = " + vet[i]);
                    i++;
                    if (i > 999)
                    {
                        break;
                    }
                }
                i -= 1;
            }
        }
    }
}
