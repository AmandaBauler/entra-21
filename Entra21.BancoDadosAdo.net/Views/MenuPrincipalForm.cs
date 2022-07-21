using Entra21.BancoDadosAdo.net.Views.Personagens;
using Entra21.BancoDadosAdo.net.Views.TiposPersonagens;
using Entra21.BancoDadosAdo.net.Views.Unidades_Federativas;

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

        private void buttonUF_Click(object sender, EventArgs e)
        {
            var unidadeFederativa = new UnidadesFederativasListagemForm();
            unidadeFederativa.ShowDialog();
        }
    }
}
