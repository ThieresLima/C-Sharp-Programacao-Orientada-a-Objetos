using System;
using System.Collections.Generic;

namespace Conjutos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            B.Add(2);
            B.Add(4); // n aceita repetição;
            B.Remove(4);

            //A.ExceptWith(B); 
            //A.UnionWith(B);
            A.IntersectWith(B);

            foreach(int x in A) {
                Console.WriteLine(x);
            }

            Console.Write("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N)) {
                Console.WriteLine(N + " Pertence ao conjunto B");
            }
            else {
                Console.WriteLine(N + " Não  Pertence ao conjunto B");
            }
        }
    }
}
