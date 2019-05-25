using System;
using System.Globalization;

namespace _1045
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, A, B, C;
            a = 0; b = 0; c = 0;

            string[] vet = Console.ReadLine().Split(' ');

            A = float.Parse(vet[0], CultureInfo.InvariantCulture);
            B = float.Parse(vet[1], CultureInfo.InvariantCulture);
            C = float.Parse(vet[2], CultureInfo.InvariantCulture);

            if (A >= B && A > C)
            {
                a = A;
                b = B;
                c = C;
            }
            else if (A > B && A > C && C > B)
            {
                a = A;
                b = C;
                c = B;
            }
            else if (B > A && B > C && A > C)
            {
                a = B;
                b = A;
                c = C;
            }
            else if (B > A && B > C && C > A)
            {
                a = B;
                b = C;
                C = A;
            }
            else if (C > A && C > B && A > B)
            {
                a = C;
                b = A;
                c = B;
            }
            else
            {
                a = C;
                b = B;
                c = A;
            }


            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            if (a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if (a == b && a != c || b == c && b != a || c == a && c != b)
            {
                Console.WriteLine("TRIANGULO ISOCELES");
            }
            Console.ReadLine();
        }
    }
}