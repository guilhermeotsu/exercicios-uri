﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma = 0, i;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            { 
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            for (i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }      
     }hile
}
