using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {        
        static void Main(string[] args) {

            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario = " + func);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário:");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(aumento);

            Console.WriteLine("Funcionario = " + func);
        }
    }
}
