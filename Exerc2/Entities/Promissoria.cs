using Exerc2.Interfaces;

namespace Exerc2.Entities
{
    public class Promissoria : IRecebivel
    {
        private double Valor { get; set; }

        private int Dias { get; set; }

        public Promissoria(double valor, int dias)
        {
            this.Valor = valor;
            this.Dias = dias;
        }

        public double calcularValorRecebivel()
        {
            if (Dias <=30) return Valor - Valor * 0.04;
            else if (Dias <= 60) return Valor - Valor * 0.065;
            else if (Dias <= 90) return Valor - Valor * 0.85;
            else return Valor - (Valor *0.085 + (double)Dias/30 * 0.02);
        }
    }
}