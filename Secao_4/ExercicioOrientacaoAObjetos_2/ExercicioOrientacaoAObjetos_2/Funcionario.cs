

namespace ExercicioOrientacaoAObjetos_2
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario = Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
             Salario = Salario * (1 + (porcentagem/100));
        }

        public override string ToString()
        {
            return "Dados atualizados:"
                + Nome + ", " + SalarioLiquido();
        }
    }
}
