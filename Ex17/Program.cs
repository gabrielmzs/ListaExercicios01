﻿namespace Ex17 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o valor de A:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C:");
            int c = int.Parse(Console.ReadLine());

            if (a + b < c) {
                Console.WriteLine($"A soma de {a} + {b} é menor que {c}.");
            }

        }
    }
}