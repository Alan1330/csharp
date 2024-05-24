using System;

namespace Aula45Urionline1115 {
    internal class Program {    
        static void Main(string[] args) {

            string[] ponto = Console.ReadLine().Split(' ');
            int X = int.Parse(ponto[0]);
            int Y = int.Parse(ponto[1]);

            while(X != 0 && Y != 0) {
                if(X > 0 && Y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if(X < 0 && Y > 0) {
                    Console.WriteLine("segundo");
                }
                else if(X < 0 && Y < 0) {
                    Console.WriteLine("terceiro");
                }
                else if(X > 0 && Y < 0){
                    Console.WriteLine("quarto");
                }
                ponto = Console.ReadLine().Split(' ');
                X = int.Parse(ponto[0]);
                Y = int.Parse(ponto[1]);
            }
        }
    }
}