using System;
using System.Globalization;

namespace Aula23Urionline1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA, pesoA, pesoB, pesoC;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pesoA = 2;
            pesoB = 3;
            pesoC = 5;

            MEDIA = (A*pesoA + B*pesoB + C*pesoC)/(pesoA + pesoB + pesoC);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
