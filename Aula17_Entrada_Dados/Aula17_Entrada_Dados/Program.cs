using System;

namespace Aula17_Entrada_Dados // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string[] palavra = frase.Split(' ');
            string p1 = palavra[0];
            string p2 = palavra[1];
            string p3 = palavra[2];
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(p1);
            Console.WriteLine(p2);  
            Console.WriteLine(p3);
        }
    }
}