using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();

            //Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            //Ler do aquivo JSON os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Obter as informações dos ampos
            var nome = textBoxNomeCompleto.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());
            //Calcular IMC
            var imc = CalcularImc(peso, altura);

            if (indiceLinhaSelecionada == -1)
            {
                //Adicionar linha no dataGridView de pacientes
                dataGridViewTabelaIMC.Rows.Add(new object[] { ++codigo, nome, altura, peso, imc });

                AdicionarPacienteSalvandoNoArquivo(codigo, nome, peso, altura);

                return;
            }

            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridViewTabelaIMC.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

            EditarDados(nome, peso, altura);
        }
        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();
            LimparCampos();
        }
        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNomeCompleto.Text = "";
            textBoxAltura.Text = "";

            indiceLinhaSelecionada = -1;

            dataGridViewTabelaIMC.ClearSelection();
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Obter a quantidade de linhas que o usiario selecionou no DataGridView
            var quantidadeLinhasSelecionadas = dataGridViewTabelaIMC.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuario escolheu realmente apagar registro.
            if (opcaoEscolhida == DialogResult.Yes)
            {
                var indiceLinhaSelecionada = dataGridViewTabelaIMC.SelectedRows[0].Index;

                //Remove a linha utilizando o indice do DataGridView
                dataGridViewTabelaIMC.Rows.RemoveAt(indiceLinhaSelecionada);

                //Remove o paciente da lista de pacientes
                pacientes.RemoveAt(indiceLinhaSelecionada);

                //Atualiza o arquivo com lista de pacientes sem o paciente removido
                SalvarEmArquivo();
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
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value.ToString());
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value.ToString());

            textBoxNomeCompleto.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }
        private void AdicionarPacienteSalvandoNoArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso,
            };

            //Ou
            //var paciente = new Paciente();
            //paciente.Codigo = codigo;
            //paciente.Nome = nome;

            pacientes.Add(paciente);

            SalvarEmArquivo();
            LimparCampos();
        }
        private void SalvarEmArquivo()
        {
            //Converter uma lista de objetos em uma string contendo o Json.
            var pacientesJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "paciente.json";
            //Salva a string contendo o Json em um arquivo em formato de Json.
            File.WriteAllText(caminho, pacientesJson);
        }
        private void LerArquivoApresentandoPacientes()
        {
            //Validar se arquivo não existe, consequentemente não é necessario percorrer uma lista que não existe
            if (File.Exists("Paciente.json") == false)
                return;

            //Ler arquivo json e armazenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("paciente.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            //Cria uma variavel para armazenar o codigo do ultimo produto, para quando cadastrar
            //um novo, armazenar com o codigo correto
            var maiorCodigo = int.MinValue;

            //Percorre a lista de pacientes
            for (int i = 0; i < pacientes.Count; i++)
            {
                //Obtem o paciente que esta sendo percorrido
                var paciente = pacientes[i];

                //Adicionar o paciente que estava no arquivo json no DataGridView 
                dataGridViewTabelaIMC.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome,
                    paciente.Altura, paciente.Peso,
                    CalcularImc(paciente.Peso, paciente.Altura)
                });

                //Rotina para descobrir o paciente com maior codigo
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;
            }
            //Validar se conseguiu encontrar algum codigo, caso contrario n deve atualizar o codigo do novo paciente
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;
        }
        private double CalcularImc(double peso, double altura)
        {
            //Peso dividido por altura elevado a dois
            return peso / Math.Pow(altura, 2);
        }
    }
}
