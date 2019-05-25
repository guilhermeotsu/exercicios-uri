using System;
using System.Globalization;
namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i =0, nratos = 0, ncoel = 0, nsapo = 0, cob = 0;
            char tipo; int qtde =0;
            double percrato, perccoe, percsapo;

            n = int.Parse(Console.ReadLine()); 

            for (i = 1; i <= n; i ++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                qtde = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);                

                if(tipo == 'C')
                {
                    ncoel += qtde;
                } else if (tipo == 'R')
                {
                    nratos += qtde; 
                } else if (tipo == 'S')
                {
                    nsapo += qtde;
                }
                cob += qtde; 
            }
            perccoe = (double)(100 * ncoel) / cob;
            percrato = (double)(100 * nratos) / cob;
            percsapo = (double)(100 * nsapo) / cob;
            
            Console.WriteLine("Total: " + cob + " cobaias" +
                              "\nTotal de coelhos: " + ncoel +
                              "\nTotal de ratos: " + nratos +
                              "\nTotal de sapos: " + nsapo +
                              "\nPercentual de coelhos: " + perccoe.ToString("F2", CultureInfo.InvariantCulture) + " %" +
                              "\nPercentual de ratos: " + percrato.ToString("F2", CultureInfo.InvariantCulture) + " %" +
                              "\nPercentual de sapos: " + percsapo.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.ReadLine();
        }
    }
}
