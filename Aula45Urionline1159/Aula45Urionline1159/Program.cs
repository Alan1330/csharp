﻿using System;

namespace Aula45Urionline1159 {
    internal class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            while (x!= 0) {
                
                if(x % 2 != 0) {
                    x = x + 1;
                }
                int soma = x + x + 2 + x + 4 + x + 6 + x + 8; // resumindo: 5x + 20
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}