using System;

namespace Bee1097 {
    internal class Program {
        static void Main(string[] args) {

            for(int i = 1; i <= 9; i = i + 2) {
                int j = 6 + i;
                Console.WriteLine("I=" + i + " J=" + j);
                j = j - 1;
                Console.WriteLine("I=" + i + " J=" + j);
                j = j - 1;
                Console.WriteLine("I=" + i + " J=" + j);
                j = j + i;
            }
        }
    }
}