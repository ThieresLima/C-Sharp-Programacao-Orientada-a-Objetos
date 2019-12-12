using System;

namespace Escopoeinicialização1 {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0; // precisa ser inicializada com algum valor.

            if (preco > 100.0) {
                desconto = preco * 0.1; // desconto 10%
            }

            Console.WriteLine(desconto);
        }
    }
}


