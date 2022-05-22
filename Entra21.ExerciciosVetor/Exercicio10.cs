using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            //Criei um vetor e solicite 8 números. Crie outro vetor preenchendo ele da seguinte forma.
            //-Primeira posição do vetor 2 recebe a soma da última posição do vetor 1 e a primeira posição do vetor 1.
            //- Segunda posição do vetor 2 recebe a soma da primeira posição do vetor 1 e a segunda posição do vetor 1.
            //- E continua até terminar o preenchimento do vetor 2. Obrigatório utilização de for para preencher o vetor 2.

            int [] numeros = new int[8];
            int[] soma = new int[4];
            int controle = 7;

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < soma.Length; i++)
            {
                soma[i] = numeros[i] + numeros[controle];
                controle--;
            }

            Console.Clear();
            for(int i = 0; i < soma.Length; i++)
            {
                Console.WriteLine("Soma: " + soma[i]);
            }
        }
    }
}
