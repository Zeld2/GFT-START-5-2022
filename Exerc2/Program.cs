using Exerc2.Entities;

var loop = true;

while (loop)
{
    System.Console.WriteLine("Qual o tipo do recebível?");
    System.Console.WriteLine("1- Cheque");
    System.Console.WriteLine("2- Promissória");
    System.Console.WriteLine("3- Titulo do Governo");
    var opcaoUsuario = Int32.Parse(Console.ReadLine());
    double valor = 0;
    int dias = 0;

    switch (opcaoUsuario)
    {
        case 1:
        System.Console.WriteLine("Qual o valor?");
        valor = Double.Parse(Console.ReadLine());
        System.Console.WriteLine("Qual o prazo de vencimento em dias?");
        dias = Int32.Parse(Console.ReadLine());
        var cheque = new Cheque(valor, dias);
        System.Console.WriteLine($"Valor a ser recebido: R${cheque.calcularValorRecebivel()}");
        loop = false;
            break;
        case 2:
        System.Console.WriteLine("Qual o valor?");
        valor = Double.Parse(Console.ReadLine());
        System.Console.WriteLine("Qual o prazo de vencimento em dias?");
        dias = Int32.Parse(Console.ReadLine());
        var promissoria = new Promissoria(valor, dias);
        System.Console.WriteLine($"Valor a ser recebido: R${promissoria.calcularValorRecebivel()}");
        loop = false;
            break;
        case 3:
        System.Console.WriteLine("Qual o valor?");
        valor = Double.Parse(Console.ReadLine());
        System.Console.WriteLine("Qual o prazo de vencimento em dias?");
        dias = Int32.Parse(Console.ReadLine());
        var tituloGoverno = new TituloGoverno(valor, dias);
        System.Console.WriteLine($"Valor a ser recebido: R${tituloGoverno.calcularValorRecebivel()}");
        loop = false;
            break;
        default:
            System.Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

}