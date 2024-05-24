using System;

namespace Aula49Urionline1078 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            if (N > 2 && N < 1000) {
                for (int i = 1; i <= 10; i++) {
                    int tabuada = i * N;
                    Console.WriteLine(i + " x " + N + " = " + tabuada);
                }
            }
        }
    }
}