using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            //Crie um vetor para guardar 10 nomes e apresente os dez nomes.

            string[] nomes = new string[10];
            int i = 0;

            for (i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: ");
                nomes[i] = nomes[i] + Console.ReadLine();
            }

            for (i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine((i + 1) + " - nome escolhido: " + nomes[i]);
            }
        }
    }
}
        
    

        
           
