using Entra21.BancoDadosAdo.net.Models;
using Entra21.BancoDadosAdo.net.Services;

namespace Entra21.BancoDadosAdo.net.Views.TiposPersonagens
{
    public partial class TipoPersonagemCadastroEdicaoForm : Form
    {
        public TipoPersonagemCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = textBoxTipo.Text.Trim();

            var tipoPersonagem = new TipoPersonagem();
            tipoPersonagem.Tipo = tipo;

            //Instancia do objeto de TipoPersonagemService que permitirá persistir o registro
            var tipoPersonagemService = new TipoPersonagemService();

            // Persistir a informação na tabela de tipos_personagens
            tipoPersonagemService.Cadastrar(tipoPersonagem);

            MessageBox.Show("Tipo de personagem cadastrado com sucesso");
        }
    }
}
