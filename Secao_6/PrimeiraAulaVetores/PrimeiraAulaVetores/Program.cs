using System.Globalization;

namespace PrimeiraAulaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                soma +=  vect[i];
            }

            double media = soma / n;
            Console.WriteLine($"A altura média é: {media.ToString("F2")}");
        }
    }
}