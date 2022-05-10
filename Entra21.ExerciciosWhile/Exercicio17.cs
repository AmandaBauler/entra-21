using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio17
    {
        public void Executar()
        {
            int hora = 23;
            int minutos = 59;
            int segundos = 59;

            while(hora >= 0)
            {
                while (minutos >= 0)
                {
                    while(segundos >= 0)
                    {
                        Console.WriteLine(hora.ToString("D2") + ":" + minutos.ToString("D2") + ":" + segundos.ToString("D2"));
                        segundos = segundos - 1;
                    }
                    minutos = minutos - 1;
                    segundos = 59;
                }
                hora = hora - 1;
                minutos = 59;
                segundos = 59;

            }
        }
    }
}
