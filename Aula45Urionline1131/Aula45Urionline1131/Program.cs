using System;

namespace Aula45Urionline1131 {
    internal class Program {
        static void Main(string[] args) {

            int novoGrenal = 1;
            int qtdvitoriaInter = 0;
            int qtdvitoriaGremio = 0;
            int qtdEmpates = 0;

            while (novoGrenal == 1) {

                string[] gols = Console.ReadLine().Split(' ');
                int interGols = int.Parse(gols[0]);
                int gremioGols = int.Parse(gols[1]);

                if (interGols > gremioGols) {
                    qtdvitoriaInter = qtdvitoriaInter + 1;
                }
                else if (interGols < gremioGols) {
                    qtdvitoriaGremio = qtdvitoriaGremio + 1;
                }
                else {
                    qtdEmpates = qtdEmpates + 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int total = qtdvitoriaInter + qtdvitoriaGremio + qtdEmpates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + qtdvitoriaInter);
            Console.WriteLine("Gremio:" + qtdvitoriaGremio);
            Console.WriteLine("Empates:" + qtdEmpates);

            if(qtdvitoriaInter > qtdvitoriaGremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (qtdvitoriaGremio > qtdvitoriaInter) {
                Console.WriteLine("Gremio venceu mais");
            }
            else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}