using System.Data;
using System.Data.SqlClient;
using Entra21.BancoDadosAdo.net.DataBase;
using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    // Dois pontos seguido de uma interface, quer dizer que a classe será obrigada a
    // implementar os métodos(contratos) estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            //conectar com bd
            var conexao = new Conexao().Conectar();

            //criar comando para executar o delete
            var comando = conexao.CreateCommand();

            //Definido o comando para apagar o registro
            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            //Executado o UPDATE na tabela de tipos_personagens
            comando.ExecuteNonQuery();

            //Fechar conexão
            comando.Connection.Close();
        }
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            //Será descrito a implementação do contrato definido na interface

            //Criado conexão com BancoDeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            //Criar o comando para exectar no banco de dados 
            SqlCommand comando = conexao.CreateCommand();

            //Especificando o comando que será executado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES (@TIPO)";
            comando.Parameters.AddWithValue("@TIPO", tipoPersonagem.Tipo);

            //Executado o comando de insert na tabela de tipos personagens 
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public void Editar(TipoPersonagem tipoPersonagem)
        {
            var conexao = new Conexao().Conectar();

            //Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE tipos_personagens SET tipo = @TIPO WHERE id = @ID";
            comando.Parameters.AddWithValue("@TIPO", tipoPersonagem.Tipo);
            comando.Parameters.AddWithValue("@ID", tipoPersonagem.Id);

            //Executa UPDATE na tabela de tipos_personagens
            comando.ExecuteNonQuery();

            //Fechar conexao
            comando.Connection.Close();
        }
        public TipoPersonagem ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            //Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, tipo FROM tipos_personagens WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            //Instanciando tabela em memoria para armazenar os registros na tabela em memoria
            var tabelaEmMemoria = new DataTable();

            //Executado a consulta na tabela de tipos_personagens armazenando-os na tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if(tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tipoPersonagem = new TipoPersonagem();
            //Obter a primeira coluna do select que é o Id
            tipoPersonagem.Id = Convert.ToInt32(primeiroRegistro["id"]);
            //Obter a segunda coluna do select que é o tipo
            tipoPersonagem.Tipo = primeiroRegistro["tipo"].ToString();

            //Fechar conexão
            comando.Connection.Close();

            return tipoPersonagem;
        }
        public List<TipoPersonagem> ObterTodos()
        {
            //Criado conexão com BancoDeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            //Criando tabela em memoria para posteriormente
            //carregar os registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            //Carregado na tabela em memoria os registros encontrados
            //comando o comando SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //Criado uma lista para armazenar os registros da consulta do SELECT
            var tiposPersonagens = new List<TipoPersonagem>();

            //Percorrido cada um dos registros da 
            //tabelaEmMemoria(registro do SELECT)
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //Obtido o registro da linha que esta sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                //Instaniando objeto da classe TipoPersonagem percorrendo com as informações do SELECT,
                //da linha que está sendo percorrida
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"]);
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                //Adicionando tipoPersonagem instanciando na lista de TipoPersonagem
                tiposPersonagens.Add(tipoPersonagem);

            }
            //Fechado a conexão com banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }
    }
}
