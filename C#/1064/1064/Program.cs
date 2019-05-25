using System;
using System.Globalization;

namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i, pos = 0, npos = 0, med; 

            for(i = 0; i <= 5; i++)
            {
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n > 0)
                {
                    pos += n;
                    npos++;
                } 
            }
            med = (double)pos / npos;
            Console.WriteLine(npos + " valores positivos" + "\n" + med.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
