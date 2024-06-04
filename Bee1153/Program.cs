using System;

namespace Bee1153 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;
            if (n > 0 && n < 13) {
                for (int i = 1; i <= n; i++) {
                    fatorial = fatorial * i;                
                }
                Console.WriteLine(fatorial);

            }
        }
    }
}