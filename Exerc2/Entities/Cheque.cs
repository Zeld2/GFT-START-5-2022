using Exerc2.Interfaces;

namespace Exerc2.Entities
{
    public class Cheque : IRecebivel
    {
        private double Valor { get; set; }

        private int Dias { get; set; }

        public Cheque(double valor, int dias)
        {
            this.Valor = valor;
            this.Dias = dias;
        }

        public double calcularValorRecebivel()
        {
            if (Dias <=30) return Valor - Valor * 0.05;
            else if (Dias <= 60) return Valor - Valor * 0.075;
            else if (Dias <= 90) return Valor - Valor  * 0.10;
            else return Valor - (Valor *0.1 + Valor * ((double)Dias-90)/30 * 0.03);
        }
    }
}