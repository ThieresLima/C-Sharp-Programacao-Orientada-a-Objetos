﻿using System;

namespace Params {
    class Program {
        static void Main(string[] args) {

            // int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
            // Console.WriteLine(result);

            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(result);
        }
    }
}
