namespace PrimeiroExemploProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Tv", 500.00, 10);

            //Exemplo de risco de possuir atributos sempre como publicos
            //produto.Quantidade = -10;

            Console.WriteLine(produto.Nome);

            Console.WriteLine("Informe um nome:");
            string novoNome = Console.ReadLine();
            produto.Nome = novoNome;

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Quantidade);
            Console.WriteLine(produto.Preco);

        }
    }
}