using System;

namespace Aula38Urionline {
    internal class Program {
        static void Main(string[] args) {

            string[] tempo = Console.ReadLine().Split(' ');

            int horaInicial, minInicial, horaFinal, minFinal, duracao;

            horaInicial = int.Parse(tempo[0]);
            minInicial = int.Parse(tempo[1]);
            horaFinal = int.Parse(tempo[2]);
            minFinal = int.Parse(tempo[3]);

            //tranformar para menor unidade de tempo, no caso o minuto.

            int inicioEmMinutos = horaInicial * 60 + minInicial;
            int fimEmMinutos = horaFinal * 60 + minFinal;

            if(inicioEmMinutos < fimEmMinutos) {
                duracao = fimEmMinutos - inicioEmMinutos;
            }
            else {
                duracao = 24 * 60 - inicioEmMinutos + fimEmMinutos;    
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}