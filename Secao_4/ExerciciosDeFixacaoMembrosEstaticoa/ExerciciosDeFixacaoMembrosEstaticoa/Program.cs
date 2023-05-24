using System.Globalization;
namespace ExerciciosDeFixacaoMembrosEstaticoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double quantia = ConversorDeMoeda.DolarParaReal(cotacaoDolar, dolaresComprados);

            Console.WriteLine($"Valor a ser pago em reais: {quantia}");
        }
    }
}