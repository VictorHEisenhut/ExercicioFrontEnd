using AgendaMVC.Controllers;
using AgendaMVC.Interfaces;
using AgendaMVC.Models;
using AgendaMVC.Utilities;
using AgendaMVC.Validations;
using System.Data;
using System.Data.SqlClient;

namespace AgendaMVC.Dao
{
    public class ContatoDao : ICrud<Contato>
    {
        private SqlConnection connection;

        public ContatoDao(SqlConnection connection)
        {

            this.connection = connection;
        }
        public bool Salvar(Contato contato)
        {
            using (connection)
            {

                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO tb_contatos(Nome,Email,Fone)VALUES(@Nome,@Email,@Fone)";

                command.Parameters.Add("Nome", SqlDbType.VarChar).Value = contato.Nome;
                command.Parameters.Add("Email", SqlDbType.VarChar).Value = contato.Email;
                command.Parameters.Add("Fone", SqlDbType.VarChar).Value = contato.Fone;

                if (ContatoValidator.ValidarContato(contato))
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public bool Alterar(Contato contato)
        {
            using (connection)
            {
                connection.ConnectionString = Connect.connectionString;
                connection.Open();
                SqlCommand command = connection.CreateCommand();


                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE tb_contatos SET nome = @Nome, Email = @Email, Fone = @Fone WHERE Id = @Id";
                command.Parameters.Add("Nome", SqlDbType.VarChar).Value = contato.Nome;
                command.Parameters.Add("Email", SqlDbType.VarChar).Value = contato.Email;
                command.Parameters.Add("Fone", SqlDbType.VarChar).Value = contato.Fone;
                command.Parameters.Add("Id", SqlDbType.Int).Value = contato.Id;

                command.ExecuteNonQuery();


                return true;

            }

        }

        public List<Contato> Consultar()
        {
            List<Contato> contatos = new();
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM tb_contatos";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Contato ctt = new Contato();
                    ctt.Id = Convert.ToInt32(reader["Id"]);
                    ctt.Nome = Convert.ToString(reader["Nome"]);
                    ctt.Email = Convert.ToString(reader["Email"]);
                    ctt.Fone = Convert.ToString(reader["Fone"]);

                    contatos.Add(ctt);
                }
                reader.Close();
                command.ExecuteNonQuery();


                return contatos;

            }
        }

        public Contato Consultar(int id)
        {
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM tb_contatos WHERE Id = @Id";
                command.Parameters.Add("Id", SqlDbType.Int).Value = id;


                SqlDataReader reader = command.ExecuteReader();

                Contato ctt = new Contato();
                while (reader.Read())
                {
                    ctt.Id = Convert.ToInt32(reader["Id"]);
                    ctt.Nome = Convert.ToString(reader["Nome"]);
                    ctt.Email = Convert.ToString(reader["Email"]);
                    ctt.Fone = Convert.ToString(reader["Fone"]);

                }
                reader.Close();
                command.ExecuteNonQuery();


                return ctt;

            }
        }

        public bool Deletar(Contato ctt)
        {
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM tb_contatos WHERE Id = @id";
                command.Parameters.Add("id", SqlDbType.Int).Value = ctt.Id;

                command.ExecuteNonQuery();


                return command.ExecuteNonQuery() > 0;

            }
        }



    }
}
