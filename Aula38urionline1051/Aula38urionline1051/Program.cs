using System;
using System.Globalization;

namespace Aula38urionline1051 {
    internal class Program {

        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.0) {
                Console.WriteLine("Isento");
            }
           
            if (salario <= 3000.0 && salario > 2000.0) {
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500.0 && salario > 3000.0) {
                imposto = (1000.0 * 0.08) + (salario - 3000.0) * 0.18;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(salario > 4500.0){
                imposto = 1000.0 * 0.08 + 1500.0 * 0.18 + (salario - 4500.0) * 0.28;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}