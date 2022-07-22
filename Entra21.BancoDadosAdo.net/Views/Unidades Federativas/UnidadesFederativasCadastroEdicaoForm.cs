using Entra21.BancoDadosAdo.net.Models;
using Entra21.BancoDadosAdo.net.Services;

namespace Entra21.BancoDadosAdo.net.Views.Unidades_Federativas
{
    public partial class UnidadesFederativasCadastroEdicaoForm : Form
    {
        private readonly int _idEditar;
        public UnidadesFederativasCadastroEdicaoForm()
        {
            InitializeComponent();

            _idEditar = -1;  
        }
        public UnidadesFederativasCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this()
        {
            _idEditar = unidadeFederativa.Id;
            
            textBoxUF.Text = unidadeFederativa.Nome;
            textBoxSiglaUf.Text = unidadeFederativa.Sigla;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if ((textBoxUF.Text.Length < 2) || (textBoxUF.Text.Length > 100))
            {
                MessageBox.Show("Quantidade de caracteres inválida");
                return;
            }
            if (textBoxSiglaUf.Text.Length != 2)
            {
                MessageBox.Show("Permitido apenas 2 letras");
                return;
            }

            var uf = textBoxUF.Text.Trim();
            var sigla = textBoxSiglaUf.Text.Trim();

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Nome = uf;
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadesFederativasService();

            if (_idEditar == -1)
            {
                
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("UF cadastrada com sucesso");

                Close();

                return;
            }
            else
            {
                unidadeFederativa.Id = _idEditar;

                unidadeFederativaService.Editar(unidadeFederativa);

                MessageBox.Show("Tipo de personagem cadastrado com sucesso.");

                Close();
            }
            
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
