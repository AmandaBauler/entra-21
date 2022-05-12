using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double valorCarro = 0;
            int anoCarro = 0;
            int indice = 0;
            int quantidadeComecaA = 0;
            int quantidadeComecaG = 0;

            Console.WriteLine("Quantos carros cadastrar: ");
            int quantidadeDeCarros = Convert.ToInt32(Console.ReadLine());

            while (indice < quantidadeDeCarros)
            {

                Console.WriteLine("Informe o modelo do veiculo: ");
                string modelo = Console.ReadLine().ToUpper();
                if (modelo.StartsWith("A"))
                {
                    quantidadeComecaA = quantidadeComecaA + 1;
                }
                else if (modelo.StartsWith("G"))
                {
                    quantidadeComecaG = quantidadeComecaG + 1;
                }

                Console.WriteLine("Informe o valor do veiculo: ");
                valorCarro = valorCarro + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o ano do veiculo: ");
                anoCarro = anoCarro + Convert.ToInt32(Console.ReadLine());

                indice = indice + 1;
            }

            Console.WriteLine("Média do ano dos carros: " + (anoCarro / quantidadeDeCarros));
            Console.WriteLine("Média de valores dos carros: " + (valorCarro / quantidadeDeCarros));
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + quantidadeComecaG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + quantidadeComecaA);
        }
    }
}
