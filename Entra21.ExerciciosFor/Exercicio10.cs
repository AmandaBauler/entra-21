using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            try
            {
                Console.WriteLine("Escolha um numero ");
                var numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                var numeroPar = "";
                var numeroImpar = "";

                for (var contador = numeroEscolhido; contador >= (numeroEscolhido - 100); contador--)
                {
                    if (contador % 2 == 0)
                    {
                        numeroPar = numeroPar + " " + contador;
                    }
                }
                Console.WriteLine("Numeros pares " + numeroPar);

                for (var contador = numeroEscolhido; contador <= (numeroEscolhido + 100); contador++)
                {
                    if (contador % 2 != 0)
                    {
                        numeroImpar = numeroImpar + " " + contador;
                    }
                }
                Console.WriteLine("Numeros impares " + numeroImpar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Informação invalida.");
            }

        }
    }
}
