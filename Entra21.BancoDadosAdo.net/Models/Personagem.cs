﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDadosAdo.net.Models
{
    internal class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        // Editora e TipoPersonagem será preenchido com INNER JOIN
        public Editora Editora { get; set; }
        public TipoPersonagem TipoPersonagem { get; set; }
    }
}
