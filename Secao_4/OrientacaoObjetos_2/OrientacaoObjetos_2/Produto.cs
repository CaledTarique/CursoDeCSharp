using System.Globalization;

namespace OrientacaoObjetos_2
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
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
