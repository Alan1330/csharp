using System;

namespace Bee1151 {
    internal class bee1151 {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            if (n > 0 && n < 46) {

                for (int i = 0; i < n; i++) {
                    if (i == n - 1) {
                        Console.WriteLine(a);
                    }
                    else {
                        Console.Write(a + " ");
                    }

                    int aux = b;
                    b = a;
                    a = aux + b;
                }
            }
        }
    }
}