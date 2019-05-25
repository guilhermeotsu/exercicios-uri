using System;
using System.Globalization;


namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = 3.14159 * Math.Pow(r,2.00);
        
            Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));
    
            Console.ReadLine(); 

        }
    }
}
