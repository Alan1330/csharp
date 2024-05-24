using System;

namespace Aula28Urionline1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, quociente, resto, nota;

            valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);

            resto = valor;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

        }
    }
}