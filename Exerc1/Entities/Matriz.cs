namespace Exerc1.Entities
{
    public class Matriz
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public List<Celula> Celulas { get; set; }

        public Matriz(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.Celulas = new List<Celula>();
        }

    }
}