using System;

namespace Aula16_ProcessamentoDados // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Caso 1 - Processamento com variável númericas do mesmo tipo
            //int x, y;
            //x = 5;
            //y = 2 * x;
            // Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.ReadLine();

            // Caso 2 - Processamento com variável númericas diferentes.
            double x;
            int y;
            x = 5.0;
            y = (int)(2 * x);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();

            



        }
    }
}