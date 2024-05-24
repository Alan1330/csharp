using System;
using System.Globalization;

namespace Aula45Urionline1154 {
    internal class Program {
        static void Main(string[] args) {

         int idade = int.Parse(Console.ReadLine());
            int totalIdade = 0;
            int conteIdade = 0;


            while(idade >= 0) {
                totalIdade = totalIdade + idade;
                conteIdade = 1 + conteIdade;
                idade = int.Parse(Console.ReadLine());
            }

            double media = (double) totalIdade / conteIdade;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}