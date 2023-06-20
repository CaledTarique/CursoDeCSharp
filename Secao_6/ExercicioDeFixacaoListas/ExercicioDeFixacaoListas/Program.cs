namespace ExercicioDeFixacaoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario novoFuncionario = new Funcionario();

            Console.Write("Qunatos funcionarios deseja resgistar? ");
            int QtdNovosFucioanrios = int.Parse(Console.ReadLine());

            for(int i = 0; i < QtdNovosFucioanrios; i++)
            {
                Console.WriteLine($"Funcionario #{i+1}");
                Console.Write("Id: ");
                novoFuncionario.Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                novoFuncionario.Name = Console.ReadLine();
                Console.Write("Salário: ");
                novoFuncionario.Salary = double.Parse(Console.ReadLine());

                funcionarios.Add(novoFuncionario);
            }
            foreach(Funcionario func in funcionarios)
            {
                Console.WriteLine(func.Id);
                Console.WriteLine(func.Name);
                Console.WriteLine(func.Salary);

            }
        }
    }
}