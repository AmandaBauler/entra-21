using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entra21.BancoDadosAdo.net.Services;

namespace Entra21.BancoDadosAdo.net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;

        public TipoPersonagemListagemForm()
        {
            InitializeComponent();

            //Instanciando o objeto da classe TipoPersonagemService para permitir:
            // - Listar todos
            // - Editar
            // - Apagar
            tipoPersonagemService = new TipoPersonagemService();

        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }
        private void AtualizarRegistrosDataGridView()
        {
            //Obter todos os tipos de personagens cadastrados na tabela 
            //tipos_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            //removido todos os registros do dataGrid
            dataGridView1.Rows.Clear();

            //Percorrido todos os tipos de persinagens encontrados para 
            //adicionar no dataGrid permitindo o usuario visualiza-los
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Registro apagado com sucesso");
        }
    }
}
