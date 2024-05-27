using System;
using System.Globalization;

namespace Bee1079 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double v2 = Double.Parse(valores[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (v1 * 2 + v2 * 3 + v3 * 5) / (2 + 3 + 5);
                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}