using System.Globalization;
namespace AutoProperties {
    class Produto {
        private string _nome; //  _nome tem uma lógica particular, n é possivel usar properties 
        public double Preco { get; private set; } // Auto Properties
        public int Quantidade { get; private set; } // Auto Properties


        public Produto() { // Construtor padrão
        }
        public Produto(string nome, double preco, int quantidade) { // Construtor com 3 atributos;
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // GET AND SET
        public string Nome {
            get { return _nome; }

            set {
                if (value != null && Nome.Length > 1) {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}