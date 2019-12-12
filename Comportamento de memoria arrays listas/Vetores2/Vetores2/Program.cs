using System;
using System.Globalization;

namespace Vetores2 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            Console.WriteLine("Média dos preços " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
