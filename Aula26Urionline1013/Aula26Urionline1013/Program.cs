using System;
using System.Globalization;

namespace Aula26Urionline1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int A, B, S, maior, maiorFinal;
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            S = int.Parse(vet[2]);

            maior = (A + B + Math.Abs(A - B)) / 2;
            maiorFinal = (maior + S + Math.Abs(maior - S)) / 2;
            Console.WriteLine(maiorFinal + " eh o maior");
            Console.ReadLine();

        }
    }
}