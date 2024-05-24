using System;
using System.Globalization;

namespace Aula23Urionline1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B,pesoA,pesoB, MEDIA;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pesoA = 3.5;
            pesoB = 7.5;
           
            MEDIA = (A*pesoA + B*pesoB)/(pesoA + pesoB);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
