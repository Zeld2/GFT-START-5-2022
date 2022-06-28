namespace Exerc3.Entities
{
    public class Trabalhador
    {
        public string Nome { get; set; }
        public double SalarioHora { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double SalarioTotal => (HorasTrabalhadas * SalarioHora);

        public Trabalhador(string nome, double salarioHora, int horasTrabalhadas)
        {
            this.Nome = nome;
            this.SalarioHora = salarioHora;
            this.HorasTrabalhadas = horasTrabalhadas;
        }

    }
}