﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }else
            {
                for (int i = y; i <= x; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }

            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
