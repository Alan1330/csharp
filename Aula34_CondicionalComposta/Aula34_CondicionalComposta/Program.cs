// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;

namespace Aula34_CondicionalComposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, X1, X2, delta;
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = B * B - 4 * A * C;

            if( A == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                X1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                X2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                
                Console.WriteLine("R1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));
            }

            //Console.ReadLine();
        }
    }
}
