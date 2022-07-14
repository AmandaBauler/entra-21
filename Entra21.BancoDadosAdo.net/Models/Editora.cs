using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDadosAdo.net.Models
{
    internal class Editora
    {
        // O que é get set apresentado posteriormente
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Faturamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Apelido { get; set; }
    }
}
