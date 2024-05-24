using System;

namespace Aula38Urionline1046 {
    internal class Program {
        static void Main(string[] args)
        {
            string[] hora = Console.ReadLine().Split(' ');

            int inicio = int.Parse(hora[0]);
            int fim = int.Parse(hora[1]);
            int duracao = 0;

            if( inicio < fim)
            {
                duracao = fim - inicio;
            }
            else {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}