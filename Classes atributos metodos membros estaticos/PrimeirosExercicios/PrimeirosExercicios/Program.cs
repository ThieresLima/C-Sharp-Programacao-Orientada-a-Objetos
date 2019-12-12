using System;
using System.Globalization;

namespace PrimeirosExercicios {
    class Program {
        static void Main(string[] args) {

            // exercício 1
            /*  Pessoa pessoa1, pessoa2;

              pessoa1 = new Pessoa();
              pessoa2 = new Pessoa();

              Console.WriteLine("Dados da primeira pessoa:");
              pessoa1.Nome = Console.ReadLine();
              pessoa1.Idade = int.Parse(Console.ReadLine());

              Console.WriteLine("Dados da segunda pessoa:");
              pessoa2.Nome = Console.ReadLine();
              pessoa2.Idade = int.Parse(Console.ReadLine());

              if (pessoa1.Idade > pessoa2.Idade) {
                  Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
              }
              else {
                  Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
              } */

            // exercício 2

            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            funcionario1.Nome = Console.ReadLine();
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            funcionario2.Nome = Console.ReadLine();
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("Salário Médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
