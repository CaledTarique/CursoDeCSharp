namespace PrimeiroExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Tv", 500.00, 10);

            //Exemplo de risco de possuir atributos sempre como publicos
            //produto.Quantidade = -10;

            Console.WriteLine(produto.GetNome());

            Console.WriteLine("Informe um nome:");
            string novoNome = Console.ReadLine();
            produto.SetNome(novoNome);

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetQuantidade());
            Console.WriteLine(produto.GetPreco());

        }
    }
}