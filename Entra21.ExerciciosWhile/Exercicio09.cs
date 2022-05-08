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
            int numeroEscolhido = 0;
            int contador = numeroEscolhido;
            int fatorial = 1;

            Console.WriteLine("Escolha um numero: ");
            numeroEscolhido = Convert.ToInt32(Console.ReadLine());

            while (contador >= 1)
            {
                fatorial = fatorial * contador;
                contador = contador - 1;   

            }
            Console.WriteLine("O fatorial de: " + numeroEscolhido + " é " + fatorial);

        }
    }
}
