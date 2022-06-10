using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListas.Exercicio02
{
    public class Exercicio02
    {
        public void Executar()
        {
            List<string> conteudoCurso = new List<string>();
            conteudoCurso.Add("Como fazer um bolo");

            Console.WriteLine("1º Conteudo: " + conteudoCurso[0]);
            conteudoCurso[0] = "Algoritmos onde vivem? Do que se alimentam";
            conteudoCurso.Add("variáveis");
            conteudoCurso.Add("Mais para frente");
            conteudoCurso[2] = "If com E";
            conteudoCurso.Add("If com OU");
            conteudoCurso.Add("While");
            conteudoCurso.Add("For");
            Console.WriteLine("\n1º conteudo: " + conteudoCurso[0] +
                "\n2º conteudo: " + conteudoCurso[1] + "\n3º conteudo: " + conteudoCurso[2] +
                "\n4º conteudo: " + conteudoCurso[3] + "\n5º conteudo: " + conteudoCurso[4] +
                "\n6º conteudo: " + conteudoCurso[5]);
            conteudoCurso.Add("Vetor");
            conteudoCurso.Add("Vetor");
            conteudoCurso.Remove("Vetor");
            conteudoCurso.Remove("Vetor");
            conteudoCurso.Add("Vetor");
            conteudoCurso[6] = "Vetor com For um amor na minha vida";

            Console.WriteLine("\n1º conteudo: " + conteudoCurso[0] +
                "\n2º conteudo: " + conteudoCurso[1] + "\n3º conteudo: " + conteudoCurso[2] +
                "\n4º conteudo: " + conteudoCurso[3] + "\n5º conteudo: " + conteudoCurso[4] +
                "\n6º conteudo: " + conteudoCurso[5] + "\n7º conteudo: " + conteudoCurso[6]);
            conteudoCurso.Add("Classe propriedades e métodos");
            Console.WriteLine("\n1º conteudo: " + conteudoCurso[0] +
                "\n2º conteudo: " + conteudoCurso[1] + "\n3º conteudo: " + conteudoCurso[2] +
                "\n4º conteudo: " + conteudoCurso[3] + "\n5º conteudo: " + conteudoCurso[4] +
                "\n6º conteudo: " + conteudoCurso[5] + "\n7º conteudo: " + conteudoCurso[6] +
                "\n8º conteudo: " + conteudoCurso[7]);
        }
    }
}
