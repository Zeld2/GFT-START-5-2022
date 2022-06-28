
using Exerc1.Entities;

Console.WriteLine("Construindo matriz....");

Console.WriteLine("Qual será o numero de linhas?");

var linhas = Int32.Parse(Console.ReadLine());

Console.WriteLine("Qual será o numero de colunas?");

var colunas = Int32.Parse(Console.ReadLine());

var Matriz = new Matriz(linhas, colunas);

int linha = 0;
int coluna = 0;
int count = 0;
int valorCelula=0;



while(count< Matriz.Linhas * Matriz.Colunas)
{
    while(coluna<Matriz.Colunas)
    {
    while(linha< Matriz.Linhas)
    {
    System.Console.WriteLine($"Qual será o valor da célula de posicão {linha}:{coluna}?");
    valorCelula = Int32.Parse(Console.ReadLine());
    var Celula = new Celula(linha, coluna, valorCelula);
    Matriz.Celulas.Add(Celula);
    linha ++;
    count ++;
    }
    coluna ++;
    linha = 0;
    }
}

foreach (var item in Matriz.Celulas)
{
    System.Console.WriteLine($"Posição da célula: {item.Row}:{item.Column} | Valor: {item.Value}");
}












