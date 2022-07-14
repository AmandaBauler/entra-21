using System.Data.SqlClient;
using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    // Dois pontos seguido de uma interface, quer dizer que a classe será obrigada a
    // implementar os métodos(contratos) estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            //Instanciando um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates etc.
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o
            // que permitirá conectar o mesmo
            var connectionString = @"";

            //Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            //Abrir a conexao com o banco de dados
            conexao.Open();
        }
    }
}
