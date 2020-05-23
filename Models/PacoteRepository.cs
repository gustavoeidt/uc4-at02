using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace at02.Models
{
    public class PacoteRepository : Repository
    {
        public void Cadastra (Pacote p, Usuario u)
        {
            conexao.Open();

            string sql = "INSERT INTO pacotes (nome, origem, destino, atrativo, saida, retorno, id_usuario) VALUES (@nome, @origem, @destino, @atrativo, @saida, @retorno, @id_usuario)";

            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome", p.nome);
            comando.Parameters.AddWithValue("@origem", p.origem);
            comando.Parameters.AddWithValue("@destino", p.destino);
            comando.Parameters.AddWithValue("@atrativo", p.atrativo);
            comando.Parameters.AddWithValue("@saida", p.saida);
            comando.Parameters.AddWithValue("@retorno", p.retorno);
            comando.Parameters.AddWithValue("@id_usuario", u.id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Atualiza (Pacote p, Usuario u)
        {
            conexao.Open();

            string sql = "UPDATE pacotes SET nome = @nome , origem = @origem, destino = @destino, atrativo = @atrativo, saida = @saida, retorno = @retorno, id_usuario = @id_usuario WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome", p.nome);
            comando.Parameters.AddWithValue("@origem", p.origem);
            comando.Parameters.AddWithValue("@destino", p.destino);
            comando.Parameters.AddWithValue("@atrativo", p.atrativo);
            comando.Parameters.AddWithValue("@saida", p.saida);
            comando.Parameters.AddWithValue("@retorno", p.retorno);
            comando.Parameters.AddWithValue("@id", p.id);
            comando.Parameters.AddWithValue("@id_usuario", u.id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<Pacote> Lista()
        {
            conexao.Open();
            
            string sql = "SELECT * ,usuarios.nome AS autor FROM pacotes LEFT JOIN usuarios USING (id) ORDER BY pacotes.nome";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            
            MySqlDataReader reader = comando.ExecuteReader();
            List<Pacote> lista = new List<Pacote>();

            while(reader.Read())
            {

                Pacote pacote = new Pacote();
                pacote.id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    pacote.nome = reader.GetString("nome");
                
                if (!reader.IsDBNull(reader.GetOrdinal("origem")))
                    pacote.origem = reader.GetString("origem");

                if (!reader.IsDBNull(reader.GetOrdinal("destino")))
                    pacote.destino = reader.GetString("destino");

                if (!reader.IsDBNull(reader.GetOrdinal("atrativo")))
                    pacote.atrativo = reader.GetString("atrativo");

                if (!reader.IsDBNull(reader.GetOrdinal("saida")))
                    pacote.saida = reader.GetDateTime("saida");

                if (!reader.IsDBNull(reader.GetOrdinal("retorno")))
                    pacote.retorno = reader.GetDateTime("retorno");

                if (!reader.IsDBNull(reader.GetOrdinal("autor")))
                    pacote.autor = reader.GetString("autor");

                lista.Add(pacote);
            }

            conexao.Close();

            return lista;
        }

        public Pacote Lista(int id)
        {
            conexao.Open();
            
            string sql = "SELECT * FROM pacotes LEFT JOIN usuarios USING (id) WHERE pacotes.id = " + id;
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            
                Pacote pacote = new Pacote();
                pacote.id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    pacote.nome = reader.GetString("nome");
                
                if (!reader.IsDBNull(reader.GetOrdinal("origem")))
                    pacote.origem = reader.GetString("origem");

                if (!reader.IsDBNull(reader.GetOrdinal("destino")))
                    pacote.destino = reader.GetString("destino");

                if (!reader.IsDBNull(reader.GetOrdinal("atrativo")))
                    pacote.atrativo = reader.GetString("atrativo");

                if (!reader.IsDBNull(reader.GetOrdinal("saida")))
                    pacote.saida = reader.GetDateTime("saida");

                if (!reader.IsDBNull(reader.GetOrdinal("retorno")))
                    pacote.retorno = reader.GetDateTime("retorno");


            conexao.Close();

            return pacote;
        }

        public void Apaga(int id)
        {
            conexao.Open();
            
            string sql = "DELETE FROM pacotes WHERE id = " + id;
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}