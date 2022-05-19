using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio05
    {
        public void Executar()
        {

            var anoCarro = 0;
            var valorCarro = 0.0;
            var quantidadeCarros = 0;
            var quantidadeCarrosLetraG = 0;
            var quantidadeCarrosLetraA = 0;

            try
            {
                Console.WriteLine("Digite a quantidade de carros que deseja cadastrar");
                quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Informação invalida.");
            }

            for (var indice = 0; indice < quantidadeCarros; indice++)
            {

                try
                {
                    Console.WriteLine("Digite o modelo do carro:");
                    var modelo = Console.ReadLine();
                    if (modelo.ToUpper().StartsWith("G"))
                    {
                        quantidadeCarrosLetraG = quantidadeCarrosLetraG + 1;
                    }
                    else if (modelo.ToUpper().StartsWith("A"))
                    {
                        quantidadeCarrosLetraA = quantidadeCarrosLetraA + 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao informar modelo, digite uma opçao valida.");
                }
                try
                {
                    Console.WriteLine("Preço do carro: ");
                    valorCarro = valorCarro + Convert.ToDouble(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao informar preço do carro, digite uma opção valida.");
                }
                try
                {
                    Console.WriteLine("Ano do carro: ");
                    anoCarro = anoCarro + Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao informar valor do carro, digite uma opçao valida.");
                }

            }
            var mediaAnoCarros = anoCarro / quantidadeCarros;
            var mediaValorCarros = valorCarro / quantidadeCarros;

            Console.WriteLine("A média de ano dos carros é " + mediaAnoCarros);
            Console.WriteLine("A média de valor dos carros é " + mediaValorCarros);
            Console.WriteLine(quantidadeCarrosLetraG + " carros começam com a letra G");
            Console.WriteLine(quantidadeCarrosLetraA + " carros começam com a letra A");

        }
    }
}
