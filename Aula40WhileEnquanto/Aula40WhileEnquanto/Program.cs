using System;

namespace Aula40WhileEnquanto {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());

            int soma = 0;
            while(x != 0) {
                soma = soma + x;
                x = Math.Sqrt(x);
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}