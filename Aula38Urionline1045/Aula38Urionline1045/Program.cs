using System;
using System.Globalization;

namespace Aula38Urionline1045 {
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double z = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double A, B, C;

            if (x > y && x > z) {

                A = x;
                if (y > z) {

                    B = y;
                    C = z;
                }
                else {
                    B = z;
                    C = y;
                }
            }
            else if (y > z) {
               
                A = y;

                if (x > z) {
                    B = x;
                    C = z;
                }
                else {
                    B = z;
                    C = x;
                }

            }
            else {

                A = z;
                if (x > y) {
                    B = x;
                    C = y;
                }
                else {
                    B = y;
                    C = x;
                }
            }


            if (A >= B + C) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else {

                if (A * A == B * B + C * C) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }

                else if (A * A > B * B + C * C) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }

                else { 
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
