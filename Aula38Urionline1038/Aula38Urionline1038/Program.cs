using System;
using System.Globalization;

namespace Aula38Urionline1038
{
    internal class Program
    {
        static void Main(string[] ars)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codProd, quantProd;

            codProd = int.Parse(vet[0]);
            quantProd = int.Parse(vet[1]);

            double totalPagar = 0.0;

            switch (codProd)
            {
                case 1:
                    totalPagar = (double) quantProd * 4.0;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    totalPagar = (double)quantProd * 4.50;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    totalPagar = (double)quantProd * 5.0;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    totalPagar = (double)quantProd * 2.0;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    totalPagar = (double)quantProd * 1.50;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine("Valores Invalidos");
                    break;

            }
        }
    }
}