using System;

namespace Bee1042 {
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            int z = int.Parse(valores[2]);

            int a, b, c;
            // ordem crescente
            if (x < y && x < z) {
                a = x;
                if (y < z) {
                    b = y;
                    c = z;
                }
                else {
                    b = z;
                    c = y;
                }
            }
            else if (y < z) {
                a = y;
                if (z < x) {
                    b = z;
                    c = x;
                }
                else {
                    b = x;
                    c = z;
                }
            }
            else {
                a = z;
                if (x < y) {
                    b = x;
                    c = y;
                }
                else {
                    b = y;
                    c = x;
                }
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}