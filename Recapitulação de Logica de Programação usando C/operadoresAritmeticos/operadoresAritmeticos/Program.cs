using System;

namespace operadoresAritmeticos {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;

            double a = 1.0, b = -3.0, c = -4.0;/*usar o (double) ou .0 para indicar que quer uma expressão double*/

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            double raio = 456.0;
            double area = Math.PI * Math.Pow(raio, 2.0);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(area);
        }
    }
}
