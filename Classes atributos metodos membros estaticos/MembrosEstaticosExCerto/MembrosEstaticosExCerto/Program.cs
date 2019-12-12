using System;
using System.Globalization;

namespace MembrosEstaticosExCerto {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio); // Chamou a função com o nome da clase
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
