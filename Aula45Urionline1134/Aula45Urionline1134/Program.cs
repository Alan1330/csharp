using System;

namespace Aula45Urionline1134 {
    internal class Program {
        static void Main(string[] args) {

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int valor = int.Parse(Console.ReadLine());

            while (valor != 4) {

                if (valor == 1) {
                    alcool = alcool + 1;
                }
                else if (valor == 2) {
                    gasolina = gasolina + 1;
                }
                else if (valor == 3) {
                    diesel = diesel + 1;
                }

                valor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}