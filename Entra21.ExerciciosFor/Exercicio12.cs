using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio12
    {
        public void Executar()
        {
            Console.WriteLine("Cardápio:");
            Console.WriteLine("=============================Bolos==============================");
            Console.WriteLine("1- Bolo Brigadeiro                             ------ 29,50");
            Console.WriteLine("2- Bolo Floresta Negra                         ------ 2,00");
            Console.WriteLine("3- Bolo Leite com Nutella                      ------ 29,23");
            Console.WriteLine("4- Bolo Mousse de Chocolate                    ------ 7,10");
            Console.WriteLine("5- Bolo Nega Maluca                            ------ 19,33");
            Console.WriteLine("=================================================================");
            Console.WriteLine("==============================Doces==============================");
            Console.WriteLine("6- Bomba de Creme                              ------ 17,71");
            Console.WriteLine("7- Bomba de Morango                            ------ 4,82");
            Console.WriteLine("=================================================================");
            Console.WriteLine("===========================Sanduíches============================");
            Console.WriteLine("8- Filé-Mignon com fritas e cheddar            ------ 21,16");
            Console.WriteLine("9- Hambúrguer com queijos, champignon e rúcula ------ 12,70");
            Console.WriteLine("10- Provolone com salame                       ------ 19,70");
            Console.WriteLine("11- Vegetariano de berinjela                   ------ 28,22");
            Console.WriteLine("=================================================================");
            Console.WriteLine("=============================Pizzas==============================");
            Console.WriteLine("12- Calabresa                                  ------ 8,98");
            Console.WriteLine("13- Napolitana                                 ------ 0,42");
            Console.WriteLine("14- Peruana                                    ------ 18,36");
            Console.WriteLine("15- Portuguesa                                 ------ 27,50");
            Console.WriteLine("=================================================================");
            Console.WriteLine("16-                                           ------ SAIR");
            Console.WriteLine("Escolha algumas opções, informando abaixo o número do item que deseja!");

            int quantidadeBolos = 0, quantidadeDoces = 0, quantidadeSanduiches = 0, quantidadePizzas = 0;
            var valorTotal = 0.0;
            int item = int.MaxValue;

            for (var i = 0; i < int.MaxValue; i++)
            {
                try
                {
                    Console.WriteLine("Informe o número do item: ");
                    item = Convert.ToInt32(Console.ReadLine());

                    if (item == 1)
                    {
                        valorTotal = valorTotal + 29.50;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (item == 2)
                    {
                        valorTotal = valorTotal + 2.00;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (item == 3)
                    {
                        valorTotal = valorTotal + 29.23;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (item == 4)
                    {
                        valorTotal = valorTotal + 7.10;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (item == 5)
                    {
                        valorTotal = valorTotal + 19.33;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (item == 6)
                    {
                        valorTotal = valorTotal + 17.71;
                        quantidadeDoces = quantidadeDoces + 1;
                    }
                    else if (item == 7)
                    {
                        valorTotal = valorTotal + 4.82;
                        quantidadeDoces = quantidadeDoces + 1;
                    }
                    else if (item == 8)
                    {
                        valorTotal = valorTotal + 21.16;
                        quantidadeSanduiches = quantidadeSanduiches + 1;
                    }
                    else if (item == 9)
                    {
                        valorTotal = valorTotal + 12.70;
                        quantidadeSanduiches = quantidadeSanduiches + 1;
                    }
                    else if (item == 10)
                    {
                        valorTotal = valorTotal + 19.70;
                        quantidadeSanduiches = quantidadeSanduiches + 1;
                    }
                    else if (item == 11)
                    {
                        valorTotal = valorTotal + 28.22;
                        quantidadeSanduiches = quantidadeSanduiches + 1;
                    }
                    else if (item == 12)
                    {
                        valorTotal = valorTotal + 8.98;
                        quantidadePizzas = quantidadePizzas + 1;
                    }
                    else if (item == 13)
                    {
                        valorTotal = valorTotal + 0.42;
                        quantidadePizzas = quantidadePizzas + 1;
                    }
                    else if (item == 14)
                    {
                        valorTotal = valorTotal + 18.36;
                        quantidadePizzas = quantidadePizzas + 1;
                    }
                    else if (item == 15)
                    {
                        valorTotal = valorTotal + 27.50;
                        quantidadePizzas = quantidadePizzas + 1;
                    }
                    else if (item == 16)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção invalida.");
                }
                

            }
            double quantidadeTotalProduto = quantidadeBolos + quantidadeDoces + quantidadeSanduiches + quantidadePizzas;
            Console.WriteLine("O cliente escolheu " + quantidadeBolos + " bolo (os)");
            Console.WriteLine("O cliente escolheu " + quantidadeDoces + " doce (es)");
            Console.WriteLine("O cliente escolheu " + quantidadeSanduiches + " sanduiche (es)");
            Console.WriteLine("O cliente escolheu " + quantidadePizzas + " pizza (as)");
            Console.WriteLine("A quantidade de produtos comprados foi: " + quantidadeTotalProduto);
            Console.WriteLine("O valor total da compra é R$" + valorTotal);
            
        }
    }

}


