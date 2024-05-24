using System;
using System.Globalization;

namespace Aula23Urionline1010 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pecaA, pecaB, numA, numB;
            double precoA, precoB, total;
            string[] vetA = Console.ReadLine().Split(' ');

            pecaA = int.Parse(vetA[0]);
            numA = int.Parse(vetA[1]);
            precoA = double.Parse(vetA[2], CultureInfo.InvariantCulture);
            
            String[] vetB = Console.ReadLine().Split(' ');
            pecaB = int.Parse(vetB[0]);
            numB = int.Parse(vetB[1]);
            precoB = double.Parse(vetB[2], CultureInfo.InvariantCulture);

            total = numA * precoA + numB * precoB;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}