using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio08
    {
        public void Executar()
        {

            var multiplicador2 = 0;
            try
            {
                var multiplicando = 0;
                Console.WriteLine("Escolha um numero ");
                var multiplicador = Convert.ToInt32(Console.ReadLine());

                for (var contador = 0; contador <= 1000; contador++)
                {
                    multiplicando = multiplicador * multiplicador2;

                    Console.WriteLine(multiplicador + " X " + multiplicador2 + " = " + multiplicando);

                    multiplicador2++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Informação Invalida.");
            }

        }
    }
}
