using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace at02.Models
{
    public class LoginRepository : Repository
    {
        public void Login (Login l)
        {
            conexao.Open();

            string sql = "SELECT * FROM usuarios WHERE login = @login AND senha = @senha";

            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@login", l.login);
            comando.Parameters.AddWithValue("@senha", l.senha);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows){
                Dados.logado = true;
                reader.Read();

                Usuario usuario = new Usuario();
                usuario.id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    usuario.nome = reader.GetString("nome");

                if (!reader.IsDBNull(reader.GetOrdinal("nascimento")))
                    usuario.nascimento = reader.GetDateTime("nascimento");

                if (!reader.IsDBNull(reader.GetOrdinal("login")))
                    usuario.login = reader.GetString("login");

                if (!reader.IsDBNull(reader.GetOrdinal("senha")))
                    usuario.senha = reader.GetString("senha");

                if (!reader.IsDBNull(reader.GetOrdinal("tipo")))
                    usuario.tipo = reader.GetBoolean("tipo");

                Dados.admin = !usuario.tipo;

                Dados.usuario = usuario;

            } else {
                Dados.logado = false;
            }

            conexao.Close();
        }

        public void Logoff()
        {
            Dados.usuario = null;
            Dados.logado = false;
            Dados.admin = false;
        }

    }
}