using System;

namespace Aula38Urionline1049 {
    internal class Program {
        static void Main(string[] args) {

            string v1 = Console.ReadLine();
            string v2 = Console.ReadLine();
            string v3 = Console.ReadLine();

            if (v1 == "vertebrado") {
                if (v2 == "ave") {
                    if (v3 == "carnivoro") {
                        Console.WriteLine("aguia");
                    }
                    else {
                        Console.WriteLine("pomba");
                    }
                }
                else {
                    if (v3 == "onivoro") {
                        Console.WriteLine("homem");
                    }
                    else {
                        Console.WriteLine("vaca");
                    }
                }
            }

            else {

                if (v2 == "ìnseto") {
                    if (v3 == "hematofago") {
                        Console.WriteLine("pulga");
                    }
                    else {
                        Console.WriteLine("lagarta");
                    }
                }
                else {
                    if (v3 == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }
                    else {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
