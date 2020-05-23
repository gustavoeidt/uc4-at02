using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace at02.Models
{
    public class UsuarioRepository : Repository
    {
        public void Cadastra (Usuario u)
        {
            conexao.Open();

            string sql = "INSERT INTO usuarios (nome, nascimento, login, senha, tipo) VALUES (@nome, @nascimento, @login, @senha, @tipo)";

            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome", u.nome);
            comando.Parameters.AddWithValue("@nascimento", u.nascimento);
            comando.Parameters.AddWithValue("@login", u.login);
            comando.Parameters.AddWithValue("@senha", u.senha);
            comando.Parameters.AddWithValue("@tipo", u.tipo);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Atualiza (Usuario u)
        {
            conexao.Open();

            string sql = "UPDATE usuarios SET nome = @nome , nascimento = @nascimento, login = @login, senha = @senha, tipo = @tipo WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome", u.nome);
            comando.Parameters.AddWithValue("@nascimento", u.nascimento);
            comando.Parameters.AddWithValue("@login", u.login);
            comando.Parameters.AddWithValue("@senha", u.senha);
            comando.Parameters.AddWithValue("@tipo", u.tipo);
            comando.Parameters.AddWithValue("@id", u.id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<Usuario> Lista()
        {
            conexao.Open();
            
            string sql = "SELECT * FROM usuarios ORDER BY nome";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            
            MySqlDataReader reader = comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();

            while(reader.Read())
            {
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

                lista.Add(usuario);
            }

            conexao.Close();

            return lista;
        }

        public Usuario Lista(int id)
        {
            conexao.Open();
            
            string sql = "SELECT * FROM usuarios WHERE id = " + id;
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            MySqlDataReader reader = comando.ExecuteReader();

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

            conexao.Close();

            return usuario;
        }

        public void Apaga(int id)
        {
            conexao.Open();
            
            string sql = "DELETE FROM usuarios WHERE id = " + id;
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}