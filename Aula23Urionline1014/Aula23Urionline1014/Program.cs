using System;
using System.Globalization;

namespace Aula23Urionline1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int KM = int.Parse(Console.ReadLine());
            double Litros, Consumo;
            Litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Consumo = KM / Litros;

            Console.WriteLine(Consumo.ToString("F3", CultureInfo.InvariantCulture)+ " km/l");
        }
    }
}