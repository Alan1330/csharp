using System;
using System.Globalization;

namespace Aula54_Vetores {
    internal class Program {
        static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n]; //declarar e indexar vetor

            for(int i =0; i<n; i++) {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//atribuir valores
            }

            for(int i =0; i < n; i++) {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}