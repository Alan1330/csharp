// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace Aula33_CondicionalSimples{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1 + nota2) / 2;
            Console.WriteLine("SUA NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
            if(media < 6.0)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}

