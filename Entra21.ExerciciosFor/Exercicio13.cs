using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio13
    {
        public void Executar()
        {
            string nomeJogadorMaiorPeso = "", nomeJogadorMenorPeso = "", nomeJogadorMaiorAltura = "";
            string jogadorMaiorNome = "", jogadorMenorNome = "                                                 ";
            double jogadorMaiorPeso = double.MinValue, jogadorMenorPeso = double.MaxValue;
            var maiorAltura = 0.0;
            var jogadoresSexoF = 0;
            var jogadoresSexoM = 0;
            int maiorQuantidadeCartaoAmarelo = int.MinValue, menorQuantidadeCartaoAmarelo = int.MaxValue;
            int maiorQuantidadeCartaoVermelho = int.MinValue, menorQuantidadeCartaoVermelho = int.MaxValue;
            string nomeJogadorMaiorQtdCartaoAmarelo = "", nomeJogadorMenorQtdCartaoAmarelo = "", nomeJogadorMaiorQtdCartaoVermelho = "";
            var nomeJogadorMenorQtdCartaoVermelho = "";

            for (var estatistica = 0; estatistica < 22; estatistica++)
            {
                Console.WriteLine("Informe seu nome: ");
                var nome = Console.ReadLine();
                var peso = 0.0;
                var altura = 0.0;
                var quantidadeCartaoAmarelo = 0;
                var quantidadeCartaoVermelhos = 0;

                try
                {
                    Console.WriteLine("Informe sua idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Idade digitada incorretamente.");
                }
                try
                {
                    Console.WriteLine("Informe seu peso: ");
                    peso = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Peso digitado incorretamente.");
                }

                Console.WriteLine("Informe seu sexo: ");
                string sexo = Console.ReadLine();

                try
                {
                    Console.WriteLine("Informe sua altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Altura invalida.");
                }
                try
                {
                    Console.WriteLine("Quantos gols marcados: ");
                    int quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Quantidade de gols invalida.");
                }
                try
                {
                    Console.WriteLine("Quantos cartões amarelos sofridos: ");
                    quantidadeCartaoAmarelo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Informação invalida.");
                }
                try
                {
                    Console.WriteLine("Quantos cartões vermelhos sofridos: ");
                    quantidadeCartaoVermelhos = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Informação invalida.");
                }

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

                if (quantidadeCartaoAmarelo == maiorQuantidadeCartaoAmarelo)
                {
                    nomeJogadorMaiorQtdCartaoAmarelo = nomeJogadorMaiorQtdCartaoAmarelo + ", " + nome;
                }

                else if (quantidadeCartaoAmarelo > maiorQuantidadeCartaoAmarelo)
                {
                    maiorQuantidadeCartaoAmarelo = quantidadeCartaoAmarelo;
                    nomeJogadorMaiorQtdCartaoAmarelo = nome;
                }

                if (quantidadeCartaoAmarelo == menorQuantidadeCartaoAmarelo)
                {
                    nomeJogadorMenorQtdCartaoAmarelo = nomeJogadorMenorQtdCartaoAmarelo + ", " + nome;
                }

                else if (quantidadeCartaoAmarelo < menorQuantidadeCartaoAmarelo)
                {
                    menorQuantidadeCartaoAmarelo = quantidadeCartaoAmarelo;
                    nomeJogadorMenorQtdCartaoAmarelo = nome;
                }

                if (quantidadeCartaoVermelhos == maiorQuantidadeCartaoVermelho)
                {
                    nomeJogadorMaiorQtdCartaoVermelho = nomeJogadorMaiorQtdCartaoVermelho + ", " + nome;
                }

                else if (quantidadeCartaoVermelhos > maiorQuantidadeCartaoVermelho)
                {
                    maiorQuantidadeCartaoVermelho = quantidadeCartaoVermelhos;
                    nomeJogadorMaiorQtdCartaoVermelho = nome;
                }

                if (quantidadeCartaoVermelhos == menorQuantidadeCartaoVermelho)
                {
                    nomeJogadorMenorQtdCartaoVermelho = nomeJogadorMenorQtdCartaoVermelho + ", " + nome;
                }

                if (quantidadeCartaoVermelhos < menorQuantidadeCartaoVermelho)
                {
                    menorQuantidadeCartaoVermelho = quantidadeCartaoVermelhos;
                    nomeJogadorMenorQtdCartaoVermelho = nome;
                }

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
