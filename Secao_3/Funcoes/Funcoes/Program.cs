using System.Globalization;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois números:");
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação desejada: + - / *");
            char operacao = char.Parse(Console.ReadLine());
            
            double resultado = CalculadoraSimples(n1, n2, operacao);
            Console.WriteLine($" O resultado da {operacao} é: {resultado.ToString("F4", CultureInfo.InvariantCulture)}");
        }

        static double CalculadoraSimples(float a, float b, char operacao)
        {
            double resultado;

            if(operacao == '+')
                resultado = a + b;
            else if(operacao == '-')  
                resultado = a - b;
            else if(operacao == '/')
                resultado = a / b;
            else
                resultado = a * b;

            return resultado;
        }
    }
}