﻿using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58); // sem especificar não é a melhor forma.

            Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d2);
            Console.WriteLine(d2.Kind);
            Console.WriteLine(d2.ToLocalTime());
            Console.WriteLine(d2.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            Console.WriteLine("==================");

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58"); // sem especificar não é a melhor forma.
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime // aramazena no formato UTC e instanciado no formato local

            Console.WriteLine(d4);
            Console.WriteLine(d4.Kind);
            Console.WriteLine(d4.ToLocalTime());
            Console.WriteLine(d4.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d5);
            Console.WriteLine(d5.Kind);
            Console.WriteLine(d5.ToLocalTime());
            Console.WriteLine(d5.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d4.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado
            Console.WriteLine(d4.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
