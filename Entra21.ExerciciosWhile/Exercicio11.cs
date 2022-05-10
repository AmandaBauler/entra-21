using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
			double numero1 = 0;
			double numero2 = 0;
			int opcao = 1;

			while (opcao != 5)
			{
				Console.WriteLine("Escolha um número: ");
				numero1 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Escolha um número: ");
				numero2 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("            MENU             ");
				Console.WriteLine("1  -------------------- SOMAR");
				Console.WriteLine("2  -------------------- SUBTRAIR");
				Console.WriteLine("3  -------------------- MULTIPLICAR");
				Console.WriteLine("4  -------------------- DIVIDIR");
				Console.WriteLine("5  -------------------- SAIR");
				Console.WriteLine("Escolha uma das opções acima:");
				opcao = Convert.ToInt32(Console.ReadLine());

				if (opcao == 1)
				{
					Console.WriteLine("Equação " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
				}
				else if (opcao == 2)
				{
					Console.WriteLine("Equação: " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
				}
				else if (opcao == 3)
				{
					Console.WriteLine("Equação: " + numero1 + " x " + numero2 + " = " + (numero1 * numero2));
				}
				else if (opcao == 4)
				{
					Console.WriteLine("Equação: " + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
				}
				else if (opcao == 5)
				{
					Console.Clear();
					Console.WriteLine("FIM.");
				}
				else
				{
					Console.WriteLine("Opção Inválida.");
				}
			}
           
        }
    }
}
