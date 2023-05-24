using System.Globalization;

namespace PrimeiroExemploSobrecarga
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {}
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; // Esta linha é dispensável, logo que por padrão é atribuido o valor 0
        }

        public double ValorTotalEmEstoque()
        {
            double total = Preco * Quantidade;
            return total;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
