using System.Globalization;

namespace PrimeiroExemploConstrutores
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;

            Console.WriteLine("Informe os dados do produto");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto:" + produto);
            Console.WriteLine("Pressione ENter para prosseguir");
            Console.ReadLine();
            Console.Clear();

            while (opc != 0)
            {
                Console.Write("Digite 1 para adicionar e 2 para retirar do estoque e 0 para sair: ");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
                    int qteAdicionada = int.Parse(Console.ReadLine());
                    produto.AdicionarProdutos(qteAdicionada);
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Digite o número de produtos a ser retirados do estoque:");
                    int qteRetirada = int.Parse(Console.ReadLine());
                    produto.RemoverProdutos(qteRetirada);  
                }
                Console.WriteLine("Dados Atualizados:" + produto);
                Console.WriteLine("Pressione ENter para prosseguir");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}