using System;
using System.Globalization;

namespace Bee1094 {
    internal class Program {
        static void Main(string[] argas) {

            int n = int.Parse(Console.ReadLine());
            int coelho = 0;
            int sapo = 0;
            int rato = 0;
            int total = 0;
            double percentCoelho = 0.0;
            double percentRato = 0.0;
            double percentSapo = 0.0;

            for (int i = 1; i <= n; i++) {

                string[] teste = Console.ReadLine().Split(' ');
                int qtd = int.Parse(teste[0]);
                char tipo = char.Parse(teste[1]);


                if ( tipo == 'C') {
                    coelho = coelho + qtd;
                }

                if (tipo == 'S') {
                    sapo = sapo + qtd;
                }

                if (tipo == 'R') {
                    rato = rato + qtd;
                }

                total = coelho + sapo + rato;
                percentCoelho = (double) 100 * coelho / total;
                percentRato = (double) 100 * rato / total;
                percentSapo = (double) 100 * sapo / total;

            }
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho );
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + percentCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}