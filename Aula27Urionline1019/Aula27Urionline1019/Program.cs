using System;

namespace Aula27Urionline1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, hora, minutos, segundos, resto;
            N = int.Parse(Console.ReadLine());

            hora = N / 3600;
            resto = N % 3600;
            
            minutos = resto / 60; // resto da divisão hora, sobra minutos.
            segundos = resto % 60;

            Console.WriteLine(hora + ":" + minutos + ":" + segundos);
            Console.ReadLine();

        }
    }
}