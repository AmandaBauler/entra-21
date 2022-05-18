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
            for (var i = 0; i < 13; i = i + 1)
            {
                try
                {
                    Console.WriteLine("Nome da peça: ");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Valor da peça: ");
                    var preco = Convert.ToDouble(Console.ReadLine());

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Informação invalida.");
                }
                
            }
        }
    }
}
