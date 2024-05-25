using System;

namespace Bee1072 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int x = n;
            int dentro = 0;
            int fora = 0;
            for (int i = 1; i <= x; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) {
                    dentro = dentro + 1;
                }
                else {
                    fora = fora + 1;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}