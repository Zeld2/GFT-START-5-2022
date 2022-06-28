namespace Exerc1.Entities
{
    public class Celula
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Value { get; set; }

        public Celula(int linha, int coluna, int valor)
        {
            this.Row = linha;
            this.Column = coluna;
            this.Value = valor;
        }
    }
}