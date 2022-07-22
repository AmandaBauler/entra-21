namespace Entra21.BancoDadosAdo.net.Views.Cidades
{
    public partial class CidadesCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        public CidadesCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
