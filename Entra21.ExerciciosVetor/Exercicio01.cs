using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            //Crie um vetor para guardar 16 números inteiros
            //preencha todas as posições com números e apresente a soma destes números.

            int[] numeros  = new int[16];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escreva um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int soma = 0;
            
            for(int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }

            Console.WriteLine("A soma dos numeros digitados é: " + soma);
            

        }
    }
}
