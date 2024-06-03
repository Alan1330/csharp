using System;

namespace Bee1143 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                int a = i;
                int b = i * i;
                int c = i * i * i;

                Console.WriteLine(a + " " + b + " " + c);
            }
        }
    }
}