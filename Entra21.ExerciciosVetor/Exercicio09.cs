using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio09
    {
        public void Executar()
        {
            //Criar dois vetores, no primeiro solicite os nomes para o usuário, o outro vetor deverá ser preenchido da seguinte forma:
            //-Primeira posição vetor 2 recebe última posição vetor 1.
            //- Segunda posição vetor 2 recebe penúltima posição vetor 1.
            //- E continua até terminar o preenchimento do vetor 2.

            string[] nomes = new string[5];
            string [] posicoes = new string[5];
            int armazenamento = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome: ");
                nomes[i] = Console.ReadLine();
            }

            for (int i = 4; i >= 0; i--)
            {
                posicoes[armazenamento] = nomes[i];
                armazenamento++;
            }

            for(int i = 0; i < posicoes.Length; i++)
            {
                Console.WriteLine("Nomes: " + posicoes[i]);
            }
        }
    }
}
