using System;

namespace AUla66_Resolvido01 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            // declaro e indexo matriz
            int[,] matriz = new int[N, N]; // obs que é matriz quadrada.

            //atribuir, gravar valores na matriz
            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            int contador = 0;
            // saída dos valores, mostrar na tela.
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    // para saída somente valores da diagonal
                    if (j == i) {
                        Console.Write(matriz[i, j] + " ");// equivalente matriz[i,i], onde linha e colunas são iguais.
                    }
                    if (matriz[i, j] < 0) {
                        contador++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + contador);

        }
    }
}