using System;
using System.Globalization;

namespace OutputData
{
     class Program
    {
        static void Main(string[] args)
        {
            char gender = 'A';
            double saldo = 125.5953168;
            int idade = 24;
            string nome = "Tarique";

            Console.WriteLine("Hello World!");
            Console.Write("Fala rapaziada!");
            Console.Write("Fala rapaziada!");
            Console.WriteLine("--------------------");
            Console.WriteLine(gender);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F3"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(idade);
            Console.WriteLine(nome);

            //PLACEHOLDER
            Console.WriteLine("{0} tem {1} anos e tem {2:F2} reais!", nome, idade, saldo);

            //INTERPOLAÇÂO
            Console.WriteLine($"{nome} tem {idade} anos e possui {saldo:F2} reais");

            //CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e possui " + saldo.ToString("F2") + " reais");

        }
    }
}