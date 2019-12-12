using System.Globalization;


namespace ExercicioDeFixacao {
    class ContaBancaria {

      public int Numero { get; private set; }
      public string Titular { get; set; }
      public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) { // Construtor
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) { // Construtor
            Deposito(depositoInicial);      // Delegando para a funcão Deposito.
        }

        public double Deposito(double quantia) {
           return Saldo += quantia;
        }

        public double Saque(double quantia) {
            return Saldo -= quantia +5;
        }
        public override string ToString() {
            return "Conta "
                + Numero
                + ", "
                + "Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
