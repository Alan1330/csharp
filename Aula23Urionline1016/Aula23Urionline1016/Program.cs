using System;
using System.Globalization;

namespace Aula23Urionline1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocX, velocY, dist, tempoAfasta;
            velocX = 1; // 1km/min
            velocY = 1.5; // 1.5km/min
           
            dist = double.Parse(Console.ReadLine());
            tempoAfasta = dist / (velocY - velocX);
            Console.WriteLine(tempoAfasta.ToString("F0", CultureInfo.InvariantCulture) + " minutos");
            Console.ReadLine();
        }
    }
}