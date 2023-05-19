using System.Globalization;

namespace MembrosEstaticos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circuferencia: {circ}");
            Console.WriteLine($"Volume: {volume}");
        }
    }
}