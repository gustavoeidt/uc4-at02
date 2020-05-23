using MySql.Data.MySqlClient;

namespace at02.Models
{
    public abstract class Repository
    {
        protected const string _strConexao = "Database=uc4at2;Data Source=localhost;User Id=root;";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}