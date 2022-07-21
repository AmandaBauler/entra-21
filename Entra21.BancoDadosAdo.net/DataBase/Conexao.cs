using System.Data.SqlClient;

namespace Entra21.BancoDadosAdo.net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            //Instanciando um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates etc.
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o
            // que permitirá conectar o mesmo
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amand\source\repos\entra-21\ExemplosSQL\BancoDeDadosReserva.mdf;Integrated Security=True;Connect Timeout=30";

            //Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            //Abrir a conexao com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
