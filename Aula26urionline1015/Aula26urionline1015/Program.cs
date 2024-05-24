using System;
using System.Globalization;

namespace Aula26Urionline1015
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vet;
            double x1, x2, y1, y2, distancia;

            vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}