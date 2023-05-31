namespace ExerciciosDeFixacaoVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DadosDoInquilino[] dadosDoInquilino = new DadosDoInquilino[10];

            Console.Write("Quantos quartos foram alugados? ");
            int quartosAlugados = int.Parse(Console.ReadLine());

            for(int i = 0; i < quartosAlugados; i++)
            {
                Console.WriteLine($"Dados do {i+1}º inquilino");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                dadosDoInquilino[quarto] = new DadosDoInquilino { Nome = nome, Email = email};
            }
            Console.Clear();
            Console.WriteLine("Quartos Ocupados:\n");
            for(int i = 0; i < 10; i++)
            {
                if (dadosDoInquilino[i] != null)
                 Console.WriteLine($"{i}: {dadosDoInquilino[i]}");
            }


        }
    }
}