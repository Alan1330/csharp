using System;

namespace Bee1073 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int x = n;
            if(n > 5 && n< 2000) {
                for(int i = 2; i <= n; i = i + 2) { //outra representação no incremento:  i +=2
                    x = (int) Math.Pow(i, 2);
                    Console.WriteLine(i + "^2" + " = " + x);
                }
            }
        }
    }
}