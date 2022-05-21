using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            //Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média dos pesos.

            double[] pesos = new double[5];
            int i = 0;

            for (i = 0;  i < pesos.Length; i++)
            {
                Console.WriteLine("Informe o peso: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
            }
            double soma = 0;

            for (i = 0; i < pesos.Length; i++)
            {
                soma = soma + pesos[i];
            }

        }

    }
}
