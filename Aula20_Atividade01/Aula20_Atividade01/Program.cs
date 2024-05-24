using System;
using System.Globalization;

namespace Aula20_Atividade01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, c, l, preco, valorArea;
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            l = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = c * l;
            valorArea = area * preco;

            Console.WriteLine("SAÍDA:");
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}