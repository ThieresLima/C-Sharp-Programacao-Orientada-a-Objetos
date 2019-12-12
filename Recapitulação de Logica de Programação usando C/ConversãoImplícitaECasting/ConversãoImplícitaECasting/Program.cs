using System;

namespace ConversãoImplícitaECasting {
    class Program {
        static void Main(string[] args) {

            /* double a;
             float b;

             a = 5.1;
             b = (float)a;

             Console.WriteLine(b); 

             double a;
             int b;

             a = 5.1;
             b = (int)a;
             Console.WriteLine(b); */

            int a = 5;
            int b = 2;

            double resultado = (double)a / b;

            Console.WriteLine(resultado);
        }
    }
}
