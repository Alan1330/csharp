using System.Globalization;

namespace Bee116 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                int val1 = int.Parse(valores[0]);
                int val2 = int.Parse(valores[1]);

                if (val2 == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double divisao = (double)val1 / val2; // cast (doble) para forca converter int em double
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}