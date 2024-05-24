using System;
using System.Globalization;

namespace Aula51DoWhile {
    internal class Program {
        static void Main(string[] args) {

            char repetir;
            do {
                Console.Write("Digite a temperatura em Celcius: ");
                double celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double fahrenheit = 9.0 * celsius / 5.0 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + fahrenheit.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
        }
    }
}