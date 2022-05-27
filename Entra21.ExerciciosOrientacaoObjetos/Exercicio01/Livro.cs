using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string CodigoIsbn;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine($"CÓDIGO {CodigoIsbn} - {Titulo} - {Autor}");
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            Console.WriteLine($"Você tera que ler no total {QuantidadePaginas} páginas.");
        }

        public void ApresentarQuantidadePaginasLidasNoTotal()
        {
            Console.WriteLine($"Você leu no total {QuantidadePaginasLidas} páginas.");
        }
    }
}
