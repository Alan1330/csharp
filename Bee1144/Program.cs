using System;

namespace Bee1144 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                int a = i;
                int b = i*i;
                int c = i*i*i;
                int d = b+1;
                int e = c + 1;
                Console.WriteLine(a + " " + b + " " + c);
                Console.WriteLine(a + " " + d + " " + e);
            }
        }
    }
}