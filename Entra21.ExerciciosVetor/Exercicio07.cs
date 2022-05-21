using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio07
    {
        public void Executar()
        {
            // Solicite a altura de 4 animais, apresente ao final a altura do animal com a menor altura.

            double[] alturaAnimais = new double[4];
            double animalComMaiorAltura = double.MinValue;
            double animalComMenorAltura = double.MaxValue;

            for (int i = 0; i < alturaAnimais.Length; i++)
            {
                try
                {
                    Console.WriteLine("Informe a altura do animal: ");
                    alturaAnimais[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Altura informada não é valida.");
                }

                if (alturaAnimais[i] > animalComMaiorAltura)
                {
                    animalComMaiorAltura = alturaAnimais[i];
                }
                else if (alturaAnimais[i] < animalComMenorAltura)
                {
                    animalComMenorAltura = alturaAnimais[i];
                }
            }
            Console.WriteLine("Maior altura do animal: " + animalComMaiorAltura);
            Console.WriteLine("Menor altura do animal: " + animalComMenorAltura);
        }
    }
}
