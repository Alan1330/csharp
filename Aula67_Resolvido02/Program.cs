using System;

namespace Aula67_Resolvido02 {
    internal class Program {
        static void Main(string[] args) {
            int L, C;
            //declara matriz
            int[,] matriz;

            string[] s = Console.ReadLine().Split(' ');
            L = int.Parse(s[0]);
            C = int.Parse(s[1]);
            // indexar matriz
            matriz = new int[L, C];

            // entrada de dados para alimentar matriz.
            for (int i = 0; i < L; i++) {
                for (int j = 0; j < C; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            //cria vetor
            int[] vetor = new int[L];

            //ler e soma os valores da matriz enviar para vetor
            for (int i = 0; i < L; i++) {
                int soma = 0;
                for (int j; j < C; j++) {
                    soma = soma + matriz[i, j];
                }
                vetor[i] = soma;
            }

            // saída soma de cada linha da matriz.
            for (int i = 0; i < L; i++) {
                Console.WriteLine(vetor[i]);
            }

        }
    }
}