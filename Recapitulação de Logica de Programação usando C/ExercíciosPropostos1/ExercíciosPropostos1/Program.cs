using System;
using System.Globalization;

namespace ExercíciosPropostos1 {
    class Program {
        static void Main(string[] args) {

            /*  int a, b, soma;

              a = int.Parse(Console.ReadLine());
              b = int.Parse(Console.ReadLine());

              soma = a + b;

              Console.WriteLine("Soma = " + soma); 

            double raio, area;

            raio = double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            // PI * o raio ao quadrado é o valor área. 

            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = a * b - c * d;

            Console.WriteLine("Diferença = " + diferenca); 

            int numero, horasTrabalho;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horasTrabalho = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());

            salario = horasTrabalho * valorHora;

            Console.WriteLine("Numero = " + numero);
            Console.WriteLine("Salário = " + salario.ToString("F2", CultureInfo.InvariantCulture));*/

            int cod1, qtd1, cod2, qtd2;
            double valor1, valor2, total;

            string[] vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            qtd1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet[0]);
            qtd2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = valor1 * qtd1 + valor2 * qtd2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

