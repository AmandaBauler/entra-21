using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = numero;
            string numeroPar = "";
            string numeroImpar = "";
            while (contador > (numero - 100))
            {
                contador = contador - 1;
                
                if (contador % 2 == 0)
                {
                    numeroPar = numeroPar + " " + contador;
                }

            }
            Console.WriteLine("Numeros pares: " + numeroPar);

            while (contador < (numero + 100))
            {
                contador = contador + 1;

                if (contador % 2 != 0)
                {
                    numeroImpar = numeroImpar + " " + contador;
                }
            }
            Console.WriteLine("Numeros impares: " + numeroImpar); 
        }
    }
}
