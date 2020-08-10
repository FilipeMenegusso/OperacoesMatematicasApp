using System;

namespace OperacoesMatematicasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine
        }

        static double LerNumeroValido(string nomeNumero)
        {
            Console.WriteLine($"Digite um número ${nomeNumero}: ");
            var numero = Console.ReadLine();

            if (double.TryParse(numero, out double resultado)) return resultado;

            return 0;
        }
    }
}
