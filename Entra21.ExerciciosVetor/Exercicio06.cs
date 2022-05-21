using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            //Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior idade.

            int[] idades = new int[9];
            int maiorIdade = 0;
            
            for (int i = 0; i < idades.Length; i++)
            {
                try
                {
                    Console.WriteLine("Informe sua idade: ");
                    idades[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Comando invalido.");
                }

                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                }
            }

            Console.WriteLine("A maior idade informada foi: " + maiorIdade);
        }
    }
}
