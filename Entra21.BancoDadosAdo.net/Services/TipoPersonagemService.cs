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
            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            //Executado o comando para apagar o registro
            comando.ExecuteNonQuery();

            //Fechar coneão com bd
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
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES ('" +
                tipoPersonagem.Tipo + "')";

            //Executado o comando de insert na tabela de tipos personagens 
            comando.ExecuteNonQuery();

            conexao.Close();
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
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
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
