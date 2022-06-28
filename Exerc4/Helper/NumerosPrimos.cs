namespace Exerc4.Helper
{
    public static class NumerosPrimos
    {
        private static bool Primo(int numero)
        {
            int divisores = 0;
            for (var i = 1; i <= numero; i++)
            {
                if(numero % i ==0) divisores ++;
            }
            if(divisores == 2) return true;
            else return false;
        }
        public static void Primos(int inicial, int final)
        {
            List<int> Primos = new List<int>();

            for (var i = inicial; i < final ; i++){
                if(Primo(i)) Primos.Add(i);
            }
            System.Console.WriteLine("Números primos: ");
            System.Console.WriteLine(String.Join(", ", Primos));

        }
    }
}