namespace ExercicioOrientacaoAObjetos_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();    

            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Digite o salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.Write("");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine(funcionario);

        }
    }
}