using System;
using System.Globalization;

namespace Aula38Urionline1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual = 0.0;
            if (salBase <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salBase <= 800.0)
            {
                percentual = 12.0;
            }

            else if (salBase <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salBase <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salBase * percentual / 100;
            double novoSalario = salBase + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}