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
            

            for (int i = 0;  i < pesos.Length; i++)
            {
                try
                {
                    Console.WriteLine("Informe o peso: ");
                    pesos[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERRO! O conteudo que digitou não é um peso.");
                }
            }
            double soma = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                soma = soma + pesos[i];
            }
            Console.WriteLine("Soma dos pesos: " + soma);
            double media = soma / pesos.Length;
            Console.WriteLine("Média dos pesos: " + media);

        }

    }
}
