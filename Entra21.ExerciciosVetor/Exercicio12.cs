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

            Console.WriteLine("Quantos produtos quer apresentar?");
            int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

            string[] produtos = new string[quantidadeNumeros];

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("Informe um produto: ");
                produtos[i] = Console.ReadLine();
            }

            for (int i = 1; i < produtos.Length; i++)
            {
                for (int j = 0; j < produtos.Length - 1; j++)
                {
                    if (produtos[i].Length < produtos[j].Length)
                    {
                        string aux = produtos[j];
                        produtos[j] = produtos[i];
                        produtos[i] = aux;
                    }
                }
            }


            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("Produto: " + produtos[i]);
            }
        }

    }
}
