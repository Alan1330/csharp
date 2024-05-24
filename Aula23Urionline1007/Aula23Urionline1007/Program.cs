using System;

namespace Aula23Urionline1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFPROD;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFPROD = A * B - C * D;
            Console.WriteLine("DIFERENCA = " + DIFPROD);
        }
    }
}
