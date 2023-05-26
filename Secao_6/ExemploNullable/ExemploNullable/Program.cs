namespace ExemploNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma de se atribuir valor null a variavel do tipo valor

            Nullable<double> x = null;
            //ou
            double? y = null;
            double? z = 10.0;

            Console.WriteLine("GetValueOrDefault:");
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(z.GetValueOrDefault());
            Console.WriteLine();

            Console.WriteLine("HasValue:");
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            Console.WriteLine(z.HasValue);
            Console.WriteLine();

            Console.WriteLine("Value:");
            if (x.HasValue)
                Console.WriteLine(x.Value);
            if (y.HasValue)
                Console.WriteLine(y.Value);
            if (z.HasValue)
                Console.WriteLine(z.Value);
            Console.WriteLine();

            Console.WriteLine("Operador de coalescência nula:");

            double w = y ?? 5.0;
            Console.WriteLine(w);
        }
    }
}