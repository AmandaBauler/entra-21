using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio08
    {
        public void Executar()
        {
            //Criar um vetor para armazenar 10 números, solicite os números e armazene.
            //Será aceito neste vetor somente números pares.

            int[] numeros = new int[10];
            
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado % 2 == 0)
                {
                    numeros[i] = numeroDigitado;
                }
                else
                {
                    i--;
                }
            }

            Console.Clear();

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Numeros do vetor: " + numeros[i]);
            }
          
        }
    }
}
