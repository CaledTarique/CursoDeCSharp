namespace ExercicioOrientacaoAObjetos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota do primeiro trimestre: ");
            aluno.Nota_1 = int.Parse(Console.ReadLine());
            Console.Write("Nota do segundo trimestre: ");
            aluno.Nota_2 = int.Parse(Console.ReadLine());
            Console.Write("Nota do terceiro trimestre: ");
            aluno.Nota_3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(aluno);
        }
    }
}