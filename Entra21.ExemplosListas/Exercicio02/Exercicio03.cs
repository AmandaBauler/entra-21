using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListas.Exercicio02
{
    public class Exercicio03
    {
        public void Executar()
        {
            List<double> notas = new List<double>();
            Console.WriteLine("Informe sua primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe sua segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe sua terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            notas.Add(nota1);
            notas.Add(nota2);
            notas.Add(nota3);
            Console.WriteLine("\nNota 01: " + notas[0] + "\nNota 02: " + notas[1] + "\nNota 03: " + notas[2]);

            double soma = notas[0] + notas[1] + notas[2];
            double media = soma / 3;
            Console.WriteLine("\nMédia final: " + media.ToString("F"));

            if (media < 6.5)
                Console.WriteLine("REPROVADO");
            else
                Console.WriteLine("APROVADO");


        }
    }
}
