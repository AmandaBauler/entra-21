using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio11
    {
        public void Executar()
        {
            //Crie um vetor e solicite os números. Crie outros dois vetores, um deles irá armazenar somente os números pares do vetor 1
            //o outro irá armazenar somente os números ímpares do vetor 1. Obrigatório utilização de for para preencher o vetor 2 e 3.

            Console.WriteLine("Informe quantos numeros deseja cadastrar");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

            int[] numerosEscolhidos = new int[quantidadeDesejada];

            for (int i = 0; i < numerosEscolhidos.Length; i++)
            {
                Console.WriteLine("Escolha um numero: ");
                numerosEscolhidos[i] = Convert.ToInt32(Console.ReadLine());
            }
            int quantidadePares = 0;
            int quantidadeImpares = 0;

            for (int i = 0; i < numerosEscolhidos.Length; i++)
            {
                if (numerosEscolhidos[i] % 2 == 0)
                {
                    quantidadePares = quantidadePares + 1;
                }
                else
                {
                    quantidadeImpares = quantidadeImpares + 1;
                }
            }

            int[] numerosPares = new int[quantidadePares];
            int[] numerosImpares = new int[quantidadeImpares];
            int controle = 0;
            int controle2 = 0;

            for (int i = 0; i < numerosEscolhidos.Length; i++)
            {
                if (numerosEscolhidos[i] % 2 == 0)
                {
                    numerosPares[controle] = numerosEscolhidos[i];
                    controle++;
                }
                else
                {
                    numerosImpares[controle2] = numerosEscolhidos[i];
                    controle2++;
                }
            }
            Console.Clear();

            for (int i = 0; i < numerosPares.Length; i++)
            {
                Console.WriteLine("Numeros Pares: " + numerosPares[i]);
            }
            for (int i = 0; i < numerosImpares.Length; i++)
            {
                Console.WriteLine("Numeros Impares: " + numerosImpares[i]);
            }
        }
    }
}
