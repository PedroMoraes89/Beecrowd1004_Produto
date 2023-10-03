using System;

namespace Beecrowd {
    class Program1004 {
        static void Main(string[] args) {

            int ValorA, ValorB, Produto;

            ValorA = int.Parse(Console.ReadLine());
            ValorB = int.Parse(Console.ReadLine());

            Produto = ValorA * ValorB;

            Console.WriteLine("PROD = " + Produto);
        }
    }
}
