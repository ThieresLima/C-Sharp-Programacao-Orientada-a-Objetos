using System;
using System.Globalization;

namespace exercicioEntrada {
    class Program {
        static void Main(string[] args) {

            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome completo:");
            Console.WriteLine(nome);
            Console.WriteLine("Quantos quartos tem na sua casa?");
            Console.WriteLine(quartos);
            Console.WriteLine("Entre com o preço de um produto:");
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Entre seu último nome, idade e altura");
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
