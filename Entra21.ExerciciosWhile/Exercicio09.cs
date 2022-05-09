using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            int fatorial = 1;

            Console.WriteLine("Escolha um numero: ");
            int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
            int contador = numeroEscolhido;
            string conta = "";

            while (contador != 1)
            {
                fatorial = fatorial * contador;
                contador = contador - 1;
                conta = conta + " " + contador;

            }
            Console.WriteLine("Fatorial de " + numeroEscolhido + " é " + numeroEscolhido + conta + "=" + fatorial);
        }
    }
}
