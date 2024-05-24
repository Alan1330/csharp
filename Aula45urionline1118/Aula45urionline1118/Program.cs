using System;
using System.Globalization;

namespace Aula45urionline1118 {
    internal class Program {
        static void Main(string[] args) {


            int X = 1;

            while (X != 2) {

                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0.0 || nota1 > 10.0) {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0.0 || nota2 > 10.0) {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                X = int.Parse(Console.ReadLine());

                while (X != 1 && X != 2) {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    X = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}