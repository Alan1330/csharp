using System;

namespace bee1132 {
    internal class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int min, max;
            if (x > y) {
                max = x;
                min = y;
            }
            else {
                max = y;
                min = x;
            }
            int soma_nao_multiplo13 = 0;

            for (int i = min; i <= max; i++) {
                
                if (i % 13 != 0) {
                    soma_nao_multiplo13 = soma_nao_multiplo13 + i;
                }
            }
            Console.WriteLine(soma_nao_multiplo13);
        }
    }
}