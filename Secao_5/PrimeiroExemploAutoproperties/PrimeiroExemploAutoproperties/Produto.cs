using System.Globalization;

namespace PrimeiroExemploAutoproperties
{
    public class Produto
    {
        // Atributo privado
        public string _nome; // Neste caso não é possível implementear autoproperties, pois existe uma lógica particular implementada.
        //Propriedades autoimplementadas
        public double Preco { get; private set; }
        public  int Quantidade { get; private set; }    

        //Construtores
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedades customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Nome não pode ser nulo ou vazio");
                else if (value.Length <= 1)
                    Console.WriteLine("Nome muito curto!");

                else
                    _nome = value;
            }
        }

        //Outros métodos da classe
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
            return _nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
