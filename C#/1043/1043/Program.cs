using System;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double area, a, b, c, perimetro; 

            a = 0; b = 0; c = 0; perimetro = 0;

            String[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (Math.Abs(a - b) < c && c < (a + b))
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2.0;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));

            }
            Console.ReadLine();
        }
    }
}
