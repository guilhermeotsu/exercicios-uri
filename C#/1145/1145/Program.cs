using System;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            
                for (int i = 1; i < y; i++)
                {
                    for (int j = 1; j <= x; j++)
                    {
                    if (i % x != 0)
                    {
                        Console.Write(i + " ");
                        i += 1;
                    }
                    else
                    {
                        Console.Write(i);
                    }
                    }
                    Console.WriteLine();                 
                }          
            Console.ReadLine();
        }
    }
}
