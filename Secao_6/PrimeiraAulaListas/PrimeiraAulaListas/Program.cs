using System.Collections.Concurrent;
namespace PrimeiraAulaListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listNames = new List<string>();

            listNames.Add("João");
            listNames.Add("Alex");
            listNames.Add("Lucas");
            listNames.Add("Debora");
            listNames.Add("Gabriel");
            listNames.Add("Ana");

            foreach(string nome in listNames)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("ListCount:" + listNames.Count);
            Console.WriteLine();
            listNames.Insert(2,"Marco ");
            foreach (string nome in listNames)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("ListCount:" + listNames.Count);


            string s1 = listNames.Find(x => x[0] == 'A');
            Console.WriteLine($"Primeiro nome com 'A': {s1}");
            string s2 = listNames.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Último nome com 'A': {s2}");

            int pos1 = listNames.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"posição do primeiro nome com 'A': {pos1}");
            int pos2 = listNames.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"posição do último nome com 'A': {pos2}");

            List<string> list2 = listNames.FindAll(x => x.Length <= 5);
            Console.WriteLine("Nomes com 5 letras ou menos");
            foreach (string name in list2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Sem o nome Gabriel");
            listNames.Remove("Gabriel");
            foreach (string name in listNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Sem o nome Marco");
            listNames.RemoveAt(2);
            foreach (string name in listNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Sem os nomes de 2-4");
            listNames.RemoveRange(2,2);
            foreach (string name in listNames)
            {
                Console.WriteLine(name);
            }


        }
    }
}