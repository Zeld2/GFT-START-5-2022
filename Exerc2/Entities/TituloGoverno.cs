using Exerc2.Interfaces;

namespace Exerc2.Entities
{
    public class TituloGoverno : IRecebivel
    {
        private double Valor { get; set; }

        private int Dias { get; set; }

        public TituloGoverno(double valor, int dias)
        {
            this.Valor = valor;
            this.Dias = dias;
        }

        public double calcularValorRecebivel()
        {
            if (Dias <= 30) return Valor - Valor * 0.03;
            else if (Dias <= 60) return Valor - Valor * 0.055;
            else if (Dias <= 90) return Valor - Valor * 0.065;
            else return Valor - (Valor *0.065 + Valor * ((double)Dias-90)/30 * 0.01);
        }
    }
}