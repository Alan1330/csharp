using System;
using System.Globalization;

namespace Aula59_multivetores {
    internal class Program {
        static void Main(string[] args) {

            string[] nomes;
            int[] idades;
            double[] altura;

            int N = int.Parse(Console.ReadLine());

            nomes = new string[N];
            idades = new int[N];
            altura = new double[N];

            //atribui dados
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //calcular das alturas
            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma = soma + altura[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " 
                + media.ToString("F2", CultureInfo.InvariantCulture));

            //Porcentagem de pessoas abaixo de 16 anos
            int cont = 0;
            for(int i = 0; i<N; i++) {
                if (idades[i] < 16) {
                    cont++;
                }
            }
            double porcentagem = (double) cont / N * 100.0;

            Console.WriteLine("Pessoas com menos de 16 anos: " 
                + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}