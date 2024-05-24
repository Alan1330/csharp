using System;

namespace Aula28Urionline1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data, resto, quociente, dias;

            dias = int.Parse(Console.ReadLine());
            resto = dias;

            data = 365;
            quociente = resto / data;
            Console.WriteLine(quociente + " ano(s)");
            resto = resto % data;

            data = 30;
            quociente = resto / data;
            Console.WriteLine(quociente + " mês(s)");
            resto = resto % data;

            data = 1;
            quociente = resto / data;
            Console.WriteLine(quociente + " dia(s)");
            resto = resto % data;

            Console.ReadLine();
        }
    }
}