using System;
using System.Globalization;

namespace Aula23Urionline1008
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberFuncionario, horaFuncionario;
            double valorHora, salario;
            numberFuncionario = int.Parse(Console.ReadLine());
            horaFuncionario = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horaFuncionario * valorHora;
            Console.WriteLine("NUMBER = " + numberFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
