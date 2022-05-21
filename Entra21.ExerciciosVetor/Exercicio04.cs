using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            //Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve conter 4 notas.
            //Solicite para o usuário o nome e as quatro notas, armazenando as notas em um vetor,
            //realize a média destas notas e apresente.

            double[] notas = new double[4];
            int i = 0;

            Console.WriteLine("Disciplina: ");
            string disciplina = Console.ReadLine();

            for(i = 0; i < notas.Length; i++)
            {
                try
                {
                    Console.WriteLine("NOTA: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERRO! Invormação digitada não é valida.");
                }
            }
            double soma = 0;
            for(i = 0; i < notas.Length; i++)
            {
                soma = soma + notas[i];
            }
            double media = soma / notas.Length;
            Console.Clear();

            for(i = 0; i < 1; i++)
            {
                Console.WriteLine("Disciplina: " + disciplina + "\nMédia da matéria: " + media);
            }
        }

    }
}
