using System;

namespace Uri1067 {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000) {


                for (int i = 0; i < x; i++) {

                    if (i % 2 == 0) {
                        i = i + 1;
                    }
                    Console.WriteLine(i);
                }
            }
        }
    }
}