using System.Data;
using System.Data.SqlClient;
using Entra21.BancoDadosAdo.net.DataBase;
using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    internal class UnidadesFederativasService : IUnidadesFederativasService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
                        
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();
                        
            comando.CommandText = "INSERT INTO unidades_federativas (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);
                        
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE unidades_federativas SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);
            comando.Parameters.AddWithValue("@ID", unidadeFederativa.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public UnidadeFederativa ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registros = tabelaEmMemoria.Rows[0];

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Id = Convert.ToInt32(registros["id"]);
            unidadeFederativa.Nome = registros["nome"].ToString();
            unidadeFederativa.Sigla = registros["sigla"].ToString();

            comando.Connection.Close();

            return unidadeFederativa;
        }

        public List<UnidadeFederativa> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var unidadeFederativa = new List<UnidadeFederativa>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var unidadesFederativas = new UnidadeFederativa();
                unidadesFederativas.Id = Convert.ToInt32(linha["id"].ToString());
                unidadesFederativas.Nome = linha["nome"].ToString();
                unidadesFederativas.Sigla = linha["sigla"].ToString();

                unidadeFederativa.Add(unidadesFederativas);

            }

            comando.Connection.Close();

            return unidadeFederativa;
        }
    }
}
