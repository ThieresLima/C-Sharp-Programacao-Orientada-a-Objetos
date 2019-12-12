using System;

namespace BoxingEunboxing {
    class Program {
        static void Main(string[] args) {

            // Boxing
            //• É o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível

            int x = 20;

            Object obj = x;

            Console.WriteLine(obj);

            // Unboxing
            // • É o processo de conversão de um objeto tipo referência para um objeto tipo valor compatível

            int y = (int)obj;

            Console.WriteLine(y);
        }
    }
}
