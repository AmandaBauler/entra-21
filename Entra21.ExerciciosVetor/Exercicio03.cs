using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            //Crie dois vetores para guardar o nome e preço de 7 produtos e apresente o
            //nome e preço dos sete produtos.

            string[] nomeProduto = new string[7];
            double[] valorProduto = new double[7];
            int i = 0;

            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("Nome do produto: ");
                nomeProduto[i] = nomeProduto[i] + Console.ReadLine();
                try
                {
                    Console.WriteLine("Preço do produto: ");
                    valorProduto[i] = valorProduto[i] + Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERRO! Informação digitada invalida.");
                }
    
            }
            Console.Clear();

            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("Produto: " + nomeProduto[i] + "\nValor do produto: R$" + valorProduto[i]);

            }

        }
    }
}
