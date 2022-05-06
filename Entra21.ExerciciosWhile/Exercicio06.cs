using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nome = "";
            double valor = 0;
            int quantidadeProdutos = 0;
            double somaValores = 0;

            while (nome != "sair")
            {
                Console.WriteLine("Nome do Produto: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade: ");
                quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

                somaValores = somaValores + valor;
            }
            double desconto = somaValores * 0.05;
            Console.WriteLine("Valor com desconto: " + (somaValores - desconto));
        }
    }
}
