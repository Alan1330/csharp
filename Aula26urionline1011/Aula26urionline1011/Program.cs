using System;
using System.Globalization;

namespace Aula26Urionline1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pi = 3.14159;
            volume = (double) 4.0 / 3 * pi * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}N