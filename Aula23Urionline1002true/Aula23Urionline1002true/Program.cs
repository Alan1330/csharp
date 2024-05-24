using System;
using System.Globalization;

namespace Aula23Urionline1002true // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, raio, area;
            n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = n*Math.Pow(raio, 2);
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}