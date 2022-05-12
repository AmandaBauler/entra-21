using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            string nome = "", nomeJogadorMaiorPeso = "", nomeJogadorMenorPeso = "", nomeJogadorMaiorAltura = "";
            double peso = 0;
            string sexo = "";
            double altura = 0;
            int quantidadeGolsMarcados = 0, quantidadeCartaoAmarelo = 0, quantidadeCartaoVermelhos = 0;
            int estatistica = 0;
            string jogadorMaiorNome = "", jogadorMenorNome = "                                                     ";
            double jogadorMaiorPeso = 0, jogadorMenorPeso = double.MaxValue;
            double maiorAltura = 0;
            int jogadoresSexoF = 0;
            int jogadoresSexoM = 0;
            int maiorQuantidadeCartaoAmarelo = 0, menorQuantidadeCartaoAmarelo = int.MaxValue;
            int maiorQuantidadeCartaoVermelho = 0, menorQuantidadeCartaoVermelho = int.MaxValue;
            string nomeJogadorMaiorQtdCartaoAmarelo = "", nomeJogadorMenorQtdCartaoAmarelo = "", nomeJogadorMaiorQtdCartaoVermelho = "";
            string nomeJogadorMenorQtdCartaoVermelho = "";

            while (estatistica <= 5)
            {
                Console.WriteLine("Informe seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Informe sua idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe seu sexo: ");
                sexo = Console.ReadLine();
                Console.WriteLine("Informe sua altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Quantos gols marcados: ");
                quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quantos cartões amarelos sofridos: ");
                quantidadeCartaoAmarelo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quantos cartões vermelhos sofridos: ");
                quantidadeCartaoVermelhos = Convert.ToInt32(Console.ReadLine());

                if (nome.Length > jogadorMaiorNome.Length)
                {
                    jogadorMaiorNome = nome;
                }

                if (nome.Length < jogadorMenorNome.Length)
                {
                    jogadorMenorNome = nome;
                }

                if (peso > jogadorMaiorPeso)
                {
                    jogadorMaiorPeso = peso;
                    nomeJogadorMaiorPeso = nome;
                }

                if (peso < jogadorMenorPeso)
                {
                    jogadorMenorPeso = peso;
                    nomeJogadorMenorPeso = nome;
                }

                if (sexo.ToUpper() == "FEMININO")
                {
                    jogadoresSexoF = jogadoresSexoF + 1;
                }

                if (sexo.ToUpper() == "MASCULINO")
                {
                    jogadoresSexoM = jogadoresSexoM + 1;
                }

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeJogadorMaiorAltura = nome;
                }

                if (quantidadeCartaoAmarelo > maiorQuantidadeCartaoAmarelo)
                {
                    maiorQuantidadeCartaoAmarelo = quantidadeCartaoAmarelo;
                    nomeJogadorMaiorQtdCartaoAmarelo = nome;
                }

                if (quantidadeCartaoAmarelo < menorQuantidadeCartaoAmarelo)
                {
                    menorQuantidadeCartaoAmarelo = quantidadeCartaoAmarelo;
                    nomeJogadorMenorQtdCartaoAmarelo = nome;
                }

                if (quantidadeCartaoVermelhos > maiorQuantidadeCartaoVermelho)
                {
                    maiorQuantidadeCartaoVermelho = quantidadeCartaoVermelhos;
                    nomeJogadorMaiorQtdCartaoVermelho = nome;
                }

                if (quantidadeCartaoVermelhos < menorQuantidadeCartaoVermelho)
                {
                    menorQuantidadeCartaoVermelho = quantidadeCartaoVermelhos;
                    nomeJogadorMenorQtdCartaoVermelho = nome;
                }

                estatistica = estatistica + 1;

            }
            Console.WriteLine(@"O jogador (a) com maior nome é " + jogadorMaiorNome);
            Console.WriteLine("O jogador (a) com menor nome é " + jogadorMenorNome);
            Console.WriteLine("O jogador (a) de maior peso é " + nomeJogadorMaiorPeso);
            Console.WriteLine("O jogador (a) de menor peso é " + nomeJogadorMenorPeso);
            Console.WriteLine("Quantidade de jogadores do sexo Feminino: " + jogadoresSexoF);
            Console.WriteLine("Quantidade de jogadores do sexo Masculino: " + jogadoresSexoM);
            Console.WriteLine("O jogador (a) com maior Altura é " + nomeJogadorMaiorAltura);
            Console.WriteLine("O jogador (a) com a maior quantidade de cartões amarelos recebidos é " + nomeJogadorMaiorQtdCartaoAmarelo);
            Console.WriteLine("O jogador (a) com a menor quantidade de cartões amarelos recebidos é " + nomeJogadorMenorQtdCartaoAmarelo);
            Console.WriteLine("O jogador (a) com a maior quantidade de cartões vermelhos recebidos é " + nomeJogadorMaiorQtdCartaoVermelho);
            Console.WriteLine("O jogador (a) com a menor quantidade de cartões vermelhos recebidos é " + nomeJogadorMenorQtdCartaoVermelho);


        }
    }
}
