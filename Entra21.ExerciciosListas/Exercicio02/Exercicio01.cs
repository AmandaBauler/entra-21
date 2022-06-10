using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListas.Exercicio02.Exercicio02
{
    public class Exercicio01
    {
        public void Executar()
        {
            List<string> melhoresFilmes = new List<string>();
            //Adicionar filmes:
            melhoresFilmes.Add("Dragon Ball Evollution");
            melhoresFilmes.Add("Titanic");
            melhoresFilmes.Add("Lanterna verde");
            //Apresentar os filmes listados
            Console.WriteLine("1º filme: " + melhoresFilmes[0] + "\n2º filme: " + melhoresFilmes[1] + "\n3º filme: " + melhoresFilmes[2]);
            //Adicionar filme
            melhoresFilmes.Add("");
            //Alterar filme
            melhoresFilmes[0] = "Dragon Ball Super: Broly";
            //Remover filme
            melhoresFilmes.Remove("Lanterna verde");
            //Verificar se filme esta na lista
            bool contemFilme = melhoresFilmes.Contains("Lanterna verde");
            if (contemFilme == true)
                Console.WriteLine("O filme Lanterna Verde esta na lista!");
            else
                Console.WriteLine("O filme Lanterna verde não esta na lista!");
            //Adicionar filme
            melhoresFilmes.Add("Quarteto fantástico");
            //Apresentar
            Console.WriteLine("1º filme: " + melhoresFilmes[0] + "\n2º filme: " + melhoresFilmes[1] + "\n3º filme: " + melhoresFilmes[2] + "\n4º filme: " + melhoresFilmes[3]);
            //Alterar filme
            melhoresFilmes[1] = "Titanic 2";
            //Apresentar
            Console.WriteLine("1º filme: " + melhoresFilmes[0] + "\n2º filme: " + melhoresFilmes[1] + "\n3º filme: " + melhoresFilmes[2] + "\n4º filme: " + melhoresFilmes[3]);
            //Verificar se filme esta na lista
            bool contemFilme1 = melhoresFilmes.Contains("A Lagoa Azul");
            if (contemFilme1 == true)
                Console.WriteLine("O filme lagoa azul esta na lista!");
            else
                Console.WriteLine("O filme lagoa azul não esta na lista!");

        }

    }
}
