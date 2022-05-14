using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            var modelo = "";
            var anoCarro = 0;
            var valorCarro = 0.0;
            var mediaAnoCarros = 0.0;
            var mediaValorCarros = 0.0;
            var quantidadeCarrosLetraG = 0;
            var quantidadeCarrosLetraA = 0;

            Console.WriteLine("Digite a quantidade de carros que deseja cadastrar");
            var quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            for (var indice = 0; indice < quantidadeCarros; indice = indice + 1)
            {
                Console.WriteLine("Digite o modelo do carro:");
                modelo = Console.ReadLine();
                if (modelo.StartsWith("G"))
                {
                    quantidadeCarrosLetraG = quantidadeCarrosLetraG + 1;
                }
                else if (modelo.StartsWith("A"))
                {
                    quantidadeCarrosLetraA = quantidadeCarrosLetraA + 1;
                }
                Console.WriteLine("Preço do carro: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());



                
            }
            

        }
    }
}
