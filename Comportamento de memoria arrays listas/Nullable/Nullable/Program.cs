using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {
            // Nullable:
            //É um recurso de C# para que dados de tipo valor (structs) possam
            //receber o valor null

            //double x = null; // erro
            //Nullable<double> x = null;
            //double? x = null;

            /* Métodos:
            • GetValueOrDefault
            • HasValue
            • Value (lança uma exceção se não houver valor) */

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // valor ou padrão
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // false
            Console.WriteLine(y.HasValue); // true

            // Console.WriteLine(x.Value); Quebrou

            if (x.HasValue)
            Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            /* Operador de coalescência nula 
             double? x = null;
             double y = x ?? 0.0;

             */
        }
    }
}
