using System.Globalization;

namespace MembrosEstaticos
{
     class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine($"Circuferencia: {circ}");
            Console.WriteLine($"Volume: {volume}");

        }
    }
}