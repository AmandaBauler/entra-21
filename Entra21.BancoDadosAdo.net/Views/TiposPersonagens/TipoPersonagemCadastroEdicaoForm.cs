using Entra21.BancoDadosAdo.net.Models;
using Entra21.BancoDadosAdo.net.Services;

namespace Entra21.BancoDadosAdo.net.Views.TiposPersonagens
{
    public partial class TipoPersonagemCadastroEdicaoForm : Form
    {
        //Armazenar o id do tipo do personagem para permitir a edição
        private int idEdicao = -1;
        public TipoPersonagemCadastroEdicaoForm()
        {
            InitializeComponent();
        }
        public TipoPersonagemCadastroEdicaoForm(TipoPersonagem tipoPersonagem) : this()
        {
            //Definido o valor do idEdiçao para posteriormente saber qual registro deve ser alterado
            idEdicao = tipoPersonagem.Id;

            //Preenchido o cmpo do tipo com o valor do banco de dados
            textBoxTipo.Text = tipoPersonagem.Tipo;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = textBoxTipo.Text.Trim();

            var tipoPersonagem = new TipoPersonagem();
            tipoPersonagem.Tipo = tipo;

            //Instancia do objeto de TipoPersonagemService que permitirá persistir o registro
            var tipoPersonagemService = new TipoPersonagemService();

            //Verifica se está em modo de cadastro
            if(idEdicao == -1)
            {
                // Persistir a informação na tabela de tipos_personagens
                tipoPersonagemService.Cadastrar(tipoPersonagem);

                MessageBox.Show("Tipo de personagem cadastrado com sucesso");

                Close();

                return;
            }

            tipoPersonagem.Id = idEdicao;
            //Atualizar a informação na tabela de tipos_personagem
            tipoPersonagemService.Editar(tipoPersonagem);

            MessageBox.Show("Tipo de personagem cadastrado com sucesso.");

            Close();
                        
        }
    }
}
