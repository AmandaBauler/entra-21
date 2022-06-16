using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private int codigo = 1;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Obter as informações dos ampos
            var nome = textBoxNomeCompleto.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());
            //Calcular IMC
            var imc = peso / (altura * altura);

            if (indiceLinhaSelecionada == -1)
            {
                dataGridViewTabelaIMC.Rows.Add(new object[] { codigo++, nome, altura, peso, imc });

                return;
            }

            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();



        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridViewTabelaIMC.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuario escolheu realmente apagar registro.
            if (opcaoEscolhida == DialogResult.Yes)
            {
                //Remove a linha utilizando o indice do DataGridView
                dataGridViewTabelaIMC.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridViewTabelaIMC.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            //Obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridViewTabelaIMC.SelectedRows[0];

            //Obter a informação da linha selecionada passado a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0]);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value.ToString());
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value.ToString());

            textBoxNomeCompleto.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }
    }
}
