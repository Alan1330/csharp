using System;
using System.Globalization;

namespace Aula26Urionline1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double pi, A, B, C, areaCirculo, areaTriangulo, areaTrapezio, areaQuadrado, areaRetangulo;
            pi = 3.14159;
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTriangulo = A * C / 2;
            areaCirculo = pi * C * C;
            areaTrapezio = (A + B) * C / 2;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
            
        }
    }
}