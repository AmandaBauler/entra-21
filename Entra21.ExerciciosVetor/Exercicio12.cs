using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio12
    {
        public void Executar()
        {
            //Crie um vetor de números e solicite. Após isto apresentar os números em ordem crescente.
            //Obrigatório utilização de for para apresentar em ordem crescente.

            Console.WriteLine("Quantos numeros quer apresentar?");
            int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[quantidadeNumeros];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escolha um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ordem crescente: " + numeros[i]);
            }
        }

    }
}
