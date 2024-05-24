using System;
using System.Globalization;

namespace Aula38Urionline1037 {
    internal class Program {
        static void Main(string[] args) {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor <= 75) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor <= 100) {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}