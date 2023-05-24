namespace PrimeiroExercicioClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Informe seu nome:");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é: {x.Nome} e você têm {x.Idade} anos de idade");
        }
    }
}