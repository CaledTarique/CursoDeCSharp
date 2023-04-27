using System;
using System.Globalization;
namespace EntradaDeDados_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Informa seua idade: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Informe seu gênero: ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.Write("Informe seu saldo: ");
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);



            Console.WriteLine($"Nome: {nome}, gênero: {sexo}, idade: {idade}, altura {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}