using Entra21.BancoDadosAdo.net.Services;

namespace Entra21.BancoDadosAdo.net.Views.Unidades_Federativas
{
    public partial class UnidadesFederativasListagemForm : Form
    {
        private readonly UnidadesFederativasService _unidadesFederativasService;
        public UnidadesFederativasListagemForm()
        {
            InitializeComponent();
            _unidadesFederativasService = new UnidadesFederativasService();

            PreencherDataGridViewComUnidadesFederativas();

        }
        private void PreencherDataGridViewComUnidadesFederativas()
        {
            var unidadeFederativa = _unidadesFederativasService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < unidadeFederativa.Count; i++)
            {
                var unidadesFederativas = unidadeFederativa[i];

                dataGridView1.Rows.Add(new object[]
                {
                    unidadesFederativas.Id,
                    unidadesFederativas.Nome,
                    unidadesFederativas.Sigla
                });
            }
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado, tente novamente.");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _unidadesFederativasService.Apagar(id);

            PreencherDataGridViewComUnidadesFederativas();

            MessageBox.Show("Registro apagado com sucesso!");
        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadesFederativasCadastroEdicaoForm = new UnidadesFederativasCadastroEdicaoForm();

            unidadesFederativasCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComUnidadesFederativas();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado, tente novamente.");
                return;
            }


            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var unidadeFederativa = _unidadesFederativasService.ObterPorId(id);
            var unidadeFederativaCadastroEdicaoForm = new UnidadesFederativasCadastroEdicaoForm(unidadeFederativa);
            unidadeFederativaCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComUnidadesFederativas();
        }
    }
}
