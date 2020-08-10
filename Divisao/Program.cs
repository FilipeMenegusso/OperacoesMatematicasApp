using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Utils.ExibirTitulo("subtração");

            var numero1 = Utils.Utils.LerNumero("primeiro");
            var numero2 = Utils.Utils.LerNumero("segundo");
            var resultado = Dividir(numero1, numero2);

            Utils.Utils.ExibirResultado("subtração", numero1, numero2, resultado);
        }

        static double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }
    }
}
