namespace ExercicioDeFixacaoListas
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; } 

        public Funcionario() { }    

        public void SalaryIncrease(int id, double percentage)
        {
            Salary = Salary * (1 + percentage/100);
        }
    }
}
