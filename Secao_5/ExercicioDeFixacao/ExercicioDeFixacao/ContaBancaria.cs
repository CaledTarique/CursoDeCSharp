using System.Globalization;

namespace ExercicioDeFixacao
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(int numeroDaConta, string nomeDoTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
        }

        public ContaBancaria(int numeroDaConta, string nomeDoTitular, double depositoInicial) : this(numeroDaConta, nomeDoTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque + 5;
        }

        public override string ToString()
        {
            return "Dados da conta: \n"
                    + "Conta " + NumeroDaConta
                    + ", Titular: " + NomeDoTitular
                    + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
