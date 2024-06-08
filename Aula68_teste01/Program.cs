using System;

namespace Aula68_teste01 {
    internal class Program {
        static void Main(string[] args) {
            int L, C;
            int[,] matriz;

            string[] s = Console.ReadLine().Split(' ');
            L = int.Parse(s[0]);
            C = int.Parse(s[1]);
            matriz = new int[L, C];

            //atribui valores
            for(int i = 0; i < L; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j=0; j< C; j++) {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for(int i=0; i< L; i++) {
                for(int j = 0; j < C; j++) {
                    if (matriz[i, j] < 0) {
                        Console.WriteLine(matriz[i,j]);
                    }
                }
            }
        }
    }
}