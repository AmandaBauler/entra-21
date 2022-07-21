using System.Data;
using Entra21.BancoDadosAdo.net.DataBase;
using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    internal class CidadesService : ICidadesService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public void Cadastrar(Cidades cidades)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO cidades(id_unidade_federativa, nome, quantidade_habitantes,
data_hora_fundacao, pib) VALUES (@ID_UNIDADE_FEDERATIVA, @NOME, @QUANTIDADE_HABITANTES, @DATA_HORA_FUNDACAO, @PIB);";

            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidades.UnidadesFederativas.Id);
            comando.Parameters.AddWithValue("@NOME", cidades.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidades.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidades.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidades.Pib);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public void Editar(Cidades cidades)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE cidades SET id_unidades_federativas = @ID_UNIDADES_FEDERATIVAS,
nome = @NOME, 
quantidade_habitantes = @QUANTIDADE_HABITANTES,
data_hora_fundacao = @DATA_HORA_FUNDACAO,
pib = @PIB
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID_UNIDADES_FEDERATIVAS", cidades.UnidadesFederativas.Id);
            comando.Parameters.AddWithValue("@NOME", cidades.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidades.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidades.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidades.Pib);
            comando.Parameters.AddWithValue("@ID", cidades.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public Cidades ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, id_unidade_federativa, nome, quantidade_habitantes, 
                data_hora_fundacao, pib WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];
            var cidades = new Cidades();
            cidades.Id = Convert.ToInt32(registro[0]);
            cidades.UnidadesFederativas = new UnidadesFederativas();
            cidades.UnidadesFederativas.Id = Convert.ToInt32(registro["id_unidades_federativas"]);
            cidades.Nome = registro["nome"].ToString();
            cidades.QuantidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
            cidades.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
            cidades.Pib = Convert.ToDecimal(registro["pib"]);

            conexao.Close();

            return cidades;
        }


    }
}
