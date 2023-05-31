namespace ExerciciosDeFixacaoVetores
{
    public class DadosDoInquilino
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public DadosDoInquilino() { }

        public DadosDoInquilino(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
