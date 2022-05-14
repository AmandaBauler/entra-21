using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            var preco = 0.0;
            var nome = "";

            for (var i = 0; i < 13; i = i + 1)
            {
                Console.WriteLine("Nome da peça: ");
                nome = Console.ReadLine();
                Console.WriteLine("Valor da peça: ");
                preco = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
