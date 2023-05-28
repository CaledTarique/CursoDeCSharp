namespace SegundaAulaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                vect[i] = new Product { Name = name, Price = price };
                soma += vect[i].Price;
            }

            double media = soma / n;

            Console.WriteLine($"A media de preço dos produtos é: {media}");
        }
    }
}