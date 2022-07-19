using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entra21.BancoDadosAdo.net.Views.Personagens;
using Entra21.BancoDadosAdo.net.Views.TiposPersonagens;

namespace Entra21.BancoDadosAdo.net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonEditoras_Click(object sender, EventArgs e)
        {

        }

        private void buttonPersonagens_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemListagemForm();
            personagemForm.ShowDialog();
        }

        private void buttonTipoPersonagem_Click(object sender, EventArgs e)
        {
            var tipoPersonagem = new TipoPersonagemListagemForm();
            tipoPersonagem.ShowDialog();
        }
    }
}
