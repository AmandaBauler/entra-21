using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio14
    {
        public void Executar()
        {
            //Crie um vetor para armazenar os nomes dos produtos. Apresentar os nomes do menor nome até o maior nome.
            //Deve listar todos os nomes do menor para o maior. Obrigatório utilização de for para apresentar os nomes do menor para o maior.

            Console.WriteLine("Quantos produtos deseja informar?");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());
            int comparandoNomes = int.MaxValue;

            string[] nomesProdutos = new string[quantidadeDesejada];

            for(int i = 0; i < nomesProdutos.Length; i++)
            {
                Console.WriteLine("Nome do produto: ");
                nomesProdutos[i] = Console.ReadLine();

                for(int j = 0; j < nomesProdutos.Length; i++)
                {
                    if(comparandoNomes > 0)
                    {
                      
                    }
                }
            }

        }
    }
}
