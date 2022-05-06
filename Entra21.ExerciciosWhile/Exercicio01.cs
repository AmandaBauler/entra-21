using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            double valorPecas = 0;
            string nome = "";
            int indice = 0;

            while (indice < 13)
            {
                Console.WriteLine("Nome da peça: ");
                nome = Console.ReadLine();
                Console.WriteLine("Valor da peça: ");
                valorPecas = Convert.ToDouble(Console.ReadLine());

                indice = indice + 1;

            }
        }
    }
}
