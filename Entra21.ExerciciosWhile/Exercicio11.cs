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
            Console.WriteLine(@"                       MENU                    |                      
                              |   1-                          Somar            |      
                              |   2-                          Subtrair         |
                              |   3-                          Multiplicar      |
                              |   4-                          Dividir          |
                              |   5-                          Sair             |
                              |------------------------------------------------|");
           
            Console.WriteLine("Informe um numero para a conta desejada: ");
            double numeroInformado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe um numero para a conta desejada: ");
            double numeroInformado2 = Convert.ToDouble(Console.ReadLine());
            double equacao = 0;
            int numeroMenu = 0;

            while(numeroMenu != 5)
            {
                Console.WriteLine("Escolha um numero do menu: ");
                numeroMenu = Convert.ToInt32(Console.ReadLine());

                if (numeroMenu == 1)
                {
                    equacao = numeroInformado + numeroInformado2;
                    Console.WriteLine("Você escolheu a operação " + numeroMenu + " e a o resultado da conta é " + equacao);
                }
                else if (numeroMenu == 2)
                {
                    equacao = numeroInformado - numeroInformado2;
                    Console.WriteLine("Você escolheu a operação " + numeroMenu + " e a o resultado da conta é " + equacao);
                }
                else if (numeroMenu == 3)
                {
                    equacao = numeroInformado * numeroInformado2;
                    Console.WriteLine("Você escolheu a operação " + numeroMenu + " e a o resultado da conta é " + equacao);
                }
                else if (numeroMenu == 4)
                {
                    equacao = numeroInformado / numeroInformado2;
                    Console.WriteLine("Você escolheu a operação " + numeroMenu + " e a o resultado da conta é " + equacao);
                }
                else
                {
                    Console.WriteLine("Você escolheu a opção Sair.");
                }
               
            }
           
        }
    }
}
