using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            int contador = 0;
            int multiplicador = 0;
            int multiplicador2 = 0;
            int multiplicando = 0;

            while (contador < 1000)
            {
                Console.WriteLine("Escolha um numero para a tabuada: ");
                multiplicador = Convert.ToInt32(Console.ReadLine());
                multiplicador2 = multiplicador2 + 1;
                multiplicando = multiplicador * multiplicador2;
                contador = contador + 1;

            }
            Console.WriteLine("-------TABUADA DO " + multiplicador + " --------");
            Console.WriteLine("LINHA TESTE");

        }
    }
}
