using System;

namespace Foreach {
    class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "Maria", "Bob", "Alex", "João" };

            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }



            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
