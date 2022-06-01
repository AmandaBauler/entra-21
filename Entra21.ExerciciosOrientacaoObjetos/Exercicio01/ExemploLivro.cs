using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            var livro = new Livro();
            livro.Titulo = "As Vantagens de ser Invisivel";
            livro.Autor = "Stephen Chbosky";
            livro.CodigoIsbn = "978-1-63-245042-5";
            livro.QuantidadePaginas = 224;
            livro.QuantidadePaginasLidas = 112;
            livro.DataLancamento = DateTime.Parse("2010/6/10");

            livro.ApresentarTituloAutor();
            livro.ApresentarQuantidadePaginasParaLer();
            livro.ApresentarQuantidadePaginasLidasNoTotal();
            livro.ApresentarAnosPosPublicacao();

        }
    }
}
