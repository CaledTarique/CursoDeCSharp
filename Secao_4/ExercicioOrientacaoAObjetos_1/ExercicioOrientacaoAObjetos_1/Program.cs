using System.Globalization;

namespace ExercicioOrientacaoAObjetos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo retangulo = new Retangulo();


            Console.Write("Informe a altura do retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a largura do retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();

            Console.WriteLine("Dados do Retângulo");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Diagonal: {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}