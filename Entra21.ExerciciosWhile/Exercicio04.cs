using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double peso = 0;
            int quantidade = 0;

            while ((peso >= 0) && (peso <= 300.00))
            {
                Console.WriteLine("Digite um peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                quantidade = quantidade + 1;

            }
            Console.WriteLine("Quantidade de pessoas: " + quantidade);

        }
    }
}
