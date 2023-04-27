using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computado";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 590;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é: R${preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo o preço é: R${preco2.ToString("F2")}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero {genero}");

        }
    }
}