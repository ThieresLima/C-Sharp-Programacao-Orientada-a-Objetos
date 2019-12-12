using System.Globalization;
namespace Course {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { //construtor padrao // Sobrecarga
        }

        // Construtor com 3 argumentos.
        public Produto(string nome, double preco, int quantidade) { // construtor 
            Nome = nome;                                            // construtor é uma operação que recebe o mesmo nome da classe.
            Preco = preco;
            Quantidade = quantidade;                                                     
        }

        public Produto(string nome, double preco) { // Sobrecarga
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }


        // this

       /* public Produto() {
            Quantidade = 0;
        }
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        } */

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
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
 