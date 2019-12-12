using System;

namespace AutoProperties {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 900.00, 5);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
