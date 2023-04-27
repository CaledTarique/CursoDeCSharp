using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace ExerciciosEstruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 1
            // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a
            // soma desses números com uma mensagem explicativa, conforme exemplos.

            //Console.WriteLine("Digite dois valores separados por '+'");
            //string[] vet = Console.ReadLine().Split("+");
            //int n1 = int.Parse(vet[0]);
            //int n2 = int.Parse(vet[1]);

            //Console.WriteLine($"Soma = {n1 + n2}");

            //EXERCICIO 2
            // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o
            // valor da área deste círculo com quatro casas decimais conforme exemplos.
            //Console.Write("Digite o raio do circulo: ");
            //double r = double.Parse(Console.ReadLine());

            //double area = Math.PI * Math.Pow(r,2);
            //Console.WriteLine($"A área deste círculo é: {area.ToString("F4", CultureInfo.InvariantCulture)} ");

            //EXERCICIO 3
            // Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir,
            // calcule e mostre a diferença do produto de A e B pelo produto de C e D
            // segundo a fórmula: DIFERENCA = (A * B - C * D).

            //Console.Write("Informe o valor de A: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Informe o valor de B: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Informe o valor de C: ");
            //double c = double.Parse(Console.ReadLine());
            //Console.Write("Informe o valor de D: ");
            //double d = double.Parse(Console.ReadLine());


            //double diferenca = (a * b) - (c * d);

            //Console.WriteLine($"A diferença do produto de A * B por C * D é igual: {diferenca}");

            // EXERCICIO 4
            // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,
            // o valor que recebe por hora e calcula o salário desse funcionário.A seguir,
            // mostre o número e o salário do funcionário, com duas casas decimais.

            //Console.Write("Informe o Número do funcionário: ");
            //int numFunc = int.Parse(Console.ReadLine());
            //Console.Write("Informe as horas trabalhadas: ");
            //float horasTrabalhadas = float.Parse(Console.ReadLine());
            //Console.Write("Informe o valor pago por hora: ");
            //float valorDaHora = float.Parse(Console.ReadLine());

            //double salario = horasTrabalhadas * valorDaHora;

            //Console.WriteLine($"O salário do funcionário {numFunc} será de R${salario.ToString("F2", CultureInfo.InvariantCulture)}");

            //EXERCICIO 5
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor
            //unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e
            //o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            //Console.WriteLine("Informe o código da peça 1, sua quantidade e valor, tudo separado por '-'");
            //string[] peca1 = Console.ReadLine().Split('-');
            //int codigoPeca1 = int.Parse(peca1[0]);
            //int quantidadePeca1 = int.Parse(peca1[1]);
            //double valorPeca1 = double.Parse(peca1[2]);
            //Console.WriteLine("Informe o código da peça 2, sua quantidade e valor, tudo separado por '-'");
            //string[] peca2 = Console.ReadLine().Split('-');
            //int codigoPeca2 = int.Parse(peca2[0]);
            //int quantidadePeca2 = int.Parse(peca2[1]);
            //double valorPeca2 = double.Parse(peca2[2]);

            //double valorTotalPeca1 = quantidadePeca1 * valorPeca1;
            //double valorTotalPeca2 = quantidadePeca2 * valorPeca2;

            //Console.WriteLine($"O valor total a ser pago pela peça 1 é R${valorTotalPeca1.ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"O valor total a ser pago pela peça 2 é R${valorTotalPeca2.ToString("F2", CultureInfo.InvariantCulture)}");


            //EXERCICIO 6
            // Fazer um programa que leia três valores com ponto flutuante de dupla precisão:
            // A, B e C. Em seguida, calcule e mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura. 
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B. 
            //e) a área do retângulo que tem lados A e B.

            Console.WriteLine("Digite três números separados por '-'");
            string[] nums = Console.ReadLine().Split('-');

            double A = double.Parse(nums[0]);
            double B = double.Parse(nums[1]);
            double C = double.Parse(nums[2]);

            double areaTrianguloRetangulo = (A * C) / 2;
            double areaCirculo = Math.PI * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine($"Área do triângulo retângulo: {areaTrianguloRetangulo}");
            Console.WriteLine($"Área do circulo : {areaCirculo}");
            Console.WriteLine($"Área do trapezio: {areaTrapezio}");
            Console.WriteLine($"Área do quadrado: {areaQuadrado}");
            Console.WriteLine($"Área do retângulo: {areaRetangulo}");
        }
    }
}