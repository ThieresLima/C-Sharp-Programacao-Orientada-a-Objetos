﻿using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            
            string original = "abcde FGHIJ ABC abc DEFG  ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); // elimina espaço em branco.
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3); // corta.
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
