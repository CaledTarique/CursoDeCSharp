using System.Globalization;
namespace ExercicioDeFixacao
{
    class Program
    {

        public static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.WriteLine("Deseja abrir uma conta (s/n)?");
            string opc = Console.ReadLine();

            if (opc == "n")
            {
                Console.Clear();
                Console.WriteLine("Que pena! \nAté mais!");
            }
            else if (opc == "s")
            {
                Console.Clear();

                Console.Write("Entre o número da conta: ");
                int numeroDaConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre o titular da conta: ");
                string nomeDoTitular = Console.ReadLine();


                Console.Write("Haverá depósito inicial (s/n)? ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's' || resp == 'S')
                {
                    Console.Write("Entre o valor de depósito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaBancaria = new ContaBancaria(numeroDaConta, nomeDoTitular, depositoInicial);
                    Console.WriteLine();
                    Console.WriteLine(contaBancaria);
                    Delay();
                }
                else
                {
                    contaBancaria = new ContaBancaria(numeroDaConta, nomeDoTitular);
                    Console.WriteLine();
                    Console.WriteLine(contaBancaria);
                    Delay();
                }
                int opc2 = 3;
                while (opc2 != 0)
                {
                    Console.WriteLine("-----Menu----- \n  Deposito - 1 \n  Saque 1- 2 \n  Sair - 0");
                    Console.WriteLine("Opção: ");
                    opc2 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opc2)
                    {
                        case 0:
                            Console.WriteLine("Até a próxima!");
                            Console.Clear();
                            break;
                        case 1:
                            Console.Write("Entre um valor para depósito: ");
                            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaBancaria.Deposito(deposito);
                            Console.WriteLine(contaBancaria);
                            Delay();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write("Entre um valor para saque: ");
                            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaBancaria.Saque(saque);
                            Console.WriteLine(contaBancaria);
                            Delay();
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!");
            }
        }

        public static void Delay()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}