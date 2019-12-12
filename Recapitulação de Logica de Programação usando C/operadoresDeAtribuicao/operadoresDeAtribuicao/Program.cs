using System;

namespace operadoresDeAtribuicao {
    class Program {
        static void Main(string[] args) {
            /* int a = 10;
             Console.WriteLine(a);

             a += 2;
             Console.WriteLine(a);

             a *= 3;
             Console.WriteLine(a);

             string s = "ABC";
             Console.WriteLine(s);

             s += "DEF";
             Console.WriteLine(s); 

             int a = 10;
             a++;
             Console.WriteLine(a); //saida: 11 

            int a = 10;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b); // saida a: 11, b: 10 */

            int a = 10;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b); // saida a: 11, b: 11 */
        }
    }
}