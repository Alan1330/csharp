using System;
using System.Globalization;

namespace Aula26urionline1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor = Console.ReadLine();
            double salarioFixo, vendasMensal, total;
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasMensal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total = salarioFixo + 0.15 * vendasMensal;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}


