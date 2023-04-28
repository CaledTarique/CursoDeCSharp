using System.Globalization;

namespace OrientacaoObjetos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();

            Console.WriteLine($"A área do triangulo é: {areaX}");

        }
    }
}