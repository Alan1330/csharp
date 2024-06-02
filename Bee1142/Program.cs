using System;

namespace Bee1142 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int x = 0;

            for (int i = 1; i <= n; i++) {
                x = x + 1;
                int a = x;
                int b = x + 1;
                int c = x + 2;
                string texto = "PUM";
                Console.WriteLine(a + " " + b + " " + c + " " + texto);
                x = x + 3;

            }
        }
    }
}