using Entra21.BancoDadosAdo.net.Models;
using Entra21.BancoDadosAdo.net.Services;

namespace Entra21.BancoDadosAdo.net.Views.Unidades_Federativas
{
    public partial class UnidadesFederativasCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;
        public UnidadesFederativasCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public UnidadesFederativasCadastroEdicaoForm(UnidadesFederativas unidadeFederativa) : this()
        {            
            idEdicao = unidadeFederativa.Id;
            
            textBoxUF.Text = unidadeFederativa.Nome;
            textBoxSiglaUf.Text = unidadeFederativa.Sigla;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var uf = textBoxUF.Text.Trim();
            var sigla = textBoxSiglaUf.Text.Trim();

            var unidadeFederativa = new UnidadesFederativas();
            unidadeFederativa.Nome = uf;
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadesFederativasService();

            if (idEdicao == -1)
            {
                
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("UF cadastrada com sucesso");

                Close();

                return;
            }

            unidadeFederativa.Id = idEdicao;

            unidadeFederativaService.Editar(unidadeFederativa);

            MessageBox.Show("Tipo de personagem cadastrado com sucesso.");

            Close();
        }
    }
}
