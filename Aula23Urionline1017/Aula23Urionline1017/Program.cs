using System;
using System.Globalization;

namespace Aula23Urionline1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo, veloc, distancia;
            double autonomia, litrosGasto;
            autonomia = 12; //12km/l
            tempo = int.Parse(Console.ReadLine());
            veloc = int.Parse(Console.ReadLine());
            distancia = veloc * tempo;
            litrosGasto = distancia / autonomia;
            Console.WriteLine(litrosGasto.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}