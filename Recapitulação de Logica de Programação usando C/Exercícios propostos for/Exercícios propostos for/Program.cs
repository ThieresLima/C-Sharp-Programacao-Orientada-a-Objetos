using System;
using System.Globalization;

namespace Exercícios_propostos_for {
    class Program {
        static void Main(string[] args) {

            /*  int x = int.Parse(Console.ReadLine());

              for (int i = 1; i <= x; i++) {
                  if (i % 2 != 0) {
                      Console.WriteLine(i);
                  }
              } 

            int n = int.Parse(Console.ReadLine());

            int count_in = 0;
            int count_out = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    count_in = count_in + 1;
                }
                else {
                    count_out = count_out + 1;
                }
            }

            Console.WriteLine(count_in + " in");
            Console.WriteLine(count_out + " out");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[0], CultureInfo.InvariantCulture);
                double c = double.Parse(line[0], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            } 

            double n = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                string[] valores = Console.ReadLine().Split();
                double x = double.Parse(valores[0]);
                double y = double.Parse(valores[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                  double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }                
            } 

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }
            Console.WriteLine(fat); 

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            } */

             int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }

    }
