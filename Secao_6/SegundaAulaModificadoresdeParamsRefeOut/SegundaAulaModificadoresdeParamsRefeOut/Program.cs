namespace SegundaAulaModificadoresdeParamsRefeOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int triple;
            Calculadora.Triple(ref a);
            Calculadora.TripleOut(b, out triple);
            Console.WriteLine(triple);
            Console.WriteLine(a);
        }
    }
}