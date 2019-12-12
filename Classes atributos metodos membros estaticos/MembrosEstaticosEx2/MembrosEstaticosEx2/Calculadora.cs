using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticosEx2 {
    class Calculadora {

        public double pi = 3.14;

        public double Circuferencia(double r) {
            return 2.0 * pi * r;
        }

        public double Volume(double r) {
            return 4.0 / 3.0 * pi * r * r * r; // Math.Pow(r, 3).
        }
    }
}
