using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            string nome = "";
            double valor = 0;
            double soma = 0;
            int quantidadeProdutos = 0;

            while (quantidadeProdutos < 5)
            {
                Console.WriteLine("Digite a quantidade de produtos: ");
                quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o nome do produto: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o valor do Produto: ");
                valor = Convert.ToDouble(Console.ReadLine());

                soma = soma + valor;

            }
            Console.WriteLine("Valor total: " + (soma - 150));
        }
    }
}
