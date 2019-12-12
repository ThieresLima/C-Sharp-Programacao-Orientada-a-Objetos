

namespace MembrosEstaticosExCerto {
    class Calculadora {

        public static double pi = 3.14; // static  permite chamar uma funcao sem instanciar um objeto.

        public static double Circunferencia(double r) {
            return 2.0 * pi * r;
        }

        public static double Volume(double r) {
            return 4.0 / 4.0 * pi * r * r * r; // Math.Pow(r, 3).
        }
    }
}
