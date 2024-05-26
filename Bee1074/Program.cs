using System;

namespace Bee1074 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int x = n;
            
            for(int i = 1; i <= x; i++) {
                n = int.Parse(Console.ReadLine());
                if(n == 0) {
                    Console.WriteLine("NULL");
                }
                else if(n % 2 ==0 && n < 0) {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (n % 2 == 0 && n > 0) {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (n % 2 != 0 && n < 0) {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (n % 2 != 0 && n > 0) {
                    Console.WriteLine("ODD POSITIVE");
                }
            }
        }
    }
}