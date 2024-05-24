using System;
using System.Globalization;

namespace Aula38Urionline1040 {
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            float a, b, c, d, media, notaExame, mediaFinal;
            a = float.Parse(valores[0], CultureInfo.InvariantCulture);
            b = float.Parse(valores[1], CultureInfo.InvariantCulture);
            c = float.Parse(valores[2], CultureInfo.InvariantCulture);
            d = float.Parse(valores[3], CultureInfo.InvariantCulture);

            //media = ((a * 2) + (b * 3) + (c * 4) + (d * 1)) / (2 + 3 + 4 + 1);
            media = (a * 2 + b * 3 + c * 4 + d * 1) / 10;

            if (media == 4.85f) {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 5.0 && media < 7.0) {
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                mediaFinal = (media + notaExame) / 2;
                if (mediaFinal >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if (mediaFinal < 5.0) {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }

            if (media >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}