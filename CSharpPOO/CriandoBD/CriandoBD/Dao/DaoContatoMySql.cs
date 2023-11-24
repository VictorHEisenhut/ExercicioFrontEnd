using CriandoBD.Entidades;
using CriandoBD.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoBD.Dao
{
    internal class DaoContatoMySql
    {
        private MySqlConnection con;
        public DaoContatoMySql()
        {
        }

        public DaoContatoMySql(MySqlConnection con)
        {
            this.con = con;
        }

        public List<Contato> contatos = new List<Contato>();
        public  bool Salvar(Contato contato)
        {
            using (con)
            {
                MySqlCommand command = con.CreateCommand();
                
                con.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO tb_contatos(nome,email,celular)VALUES(@nome,@email,@celular)";

                command.Parameters.Add("nome", MySqlDbType.VarString).Value = contato.Nome;
                command.Parameters.Add("email", MySqlDbType.VarString).Value = contato.Email;
                command.Parameters.Add("celular", MySqlDbType.VarString).Value = contato.Telefone;
                command.ExecuteNonQuery();

                command.Connection = con;
                return true;

            }

        }

        public List<Contato> Consultar()
        {
            using (MySqlConnection connection = Connect.Conectar())
            {
                MySqlCommand command = connection.CreateCommand();

                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM tb_contatos";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Contato ctt = new Contato();
                    ctt.Id = Convert.ToInt32(reader["id"]);
                    ctt.Nome = Convert.ToString(reader["nome"]);
                    ctt.Email = Convert.ToString(reader["email"]);
                    ctt.Telefone = Convert.ToString(reader["celular"]);

                    contatos.Add(ctt);
                }
                reader.Close();
                command.ExecuteNonQuery();

                command.Connection = connection;
                return contatos;

            }

        }

        public Contato ConsultarPorId(int id)
        {
            using (con)
            {
                MySqlCommand command = con.CreateCommand();

                con.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM tb_contatos WHERE id = @id";
                command.Parameters.Add("id", MySqlDbType.Int32).Value = id;

                MySqlDataReader reader = command.ExecuteReader();

                Contato ctt = new Contato();
                while (reader.Read())
                {
                    ctt.Id = Convert.ToInt32(reader["id"]);
                    ctt.Nome = Convert.ToString(reader["nome"]);
                    ctt.Email = Convert.ToString(reader["email"]);
                    ctt.Telefone = Convert.ToString(reader["celular"]);

                }
                reader.Close();
                command.ExecuteNonQuery();

                command.Connection = con;
                return ctt;

            }

        }

        public bool Atualizar(Contato contato)
        {
            using (con)
            {
                MySqlCommand command = con.CreateCommand();

                con.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE tb_contatos SET nome = @nome, email = @email, celular = @celular WHERE id = @Id";
                command.Parameters.Add("nome", MySqlDbType.VarString).Value = contato.Nome;
                command.Parameters.Add("email", MySqlDbType.VarString).Value = contato.Email;
                command.Parameters.Add("celular", MySqlDbType.VarString).Value = contato.Telefone;
                command.Parameters.Add("Id", MySqlDbType.Int32).Value = contato.Id;

                command.ExecuteNonQuery();

                command.Connection = con;
                return true;

            }

        }

        public bool Deletar(Contato contato)
        {
            using (con)
            {
                MySqlCommand command = con.CreateCommand();

                con.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM tb_contatos WHERE id = @id";
                command.Parameters.Add("id", MySqlDbType.Int32).Value = contato.Id;

                command.ExecuteNonQuery();

                command.Connection = con;
                return command.ExecuteNonQuery() > 0;

            }

        }

    }
}
