using AgendaMVC.Interfaces;
using AgendaMVC.Models;
using System.Data.SqlClient;
using System.Data;
using AgendaMVC.Utilities;

namespace AgendaMVC.Dao
{
    public class CompromissoDao : ICrud<Compromisso>
    {
        private SqlConnection connection;

        public CompromissoDao(SqlConnection connection)
        {

            this.connection = connection;
        }
        public bool Salvar(Compromisso compromisso)
        {
            using (connection)
            {

                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO tb_compromissos(Descricao,Data,ContatoId)VALUES(@Descricao,@Data,@ContatoId)";

                command.Parameters.Add("Descricao", SqlDbType.VarChar).Value = compromisso.Descricao;
                command.Parameters.Add("Data", SqlDbType.Date).Value = compromisso.Data;
                command.Parameters.Add("ContatoId", SqlDbType.Int).Value = compromisso.Contato.Id;
                command.ExecuteNonQuery();

                command.Connection = connection;
                return true;
            }
        }
        public List<Compromisso> Consultar()
        {
            List<Compromisso> compromissos = new();
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM tb_compromissos";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Compromisso comp = new Compromisso();
                    comp.Id = Convert.ToInt32(reader["Id"]);
                    comp.Descricao = Convert.ToString(reader["Descricao"]);
                    comp.Data = Convert.ToDateTime(reader["Data"]);
                    var id = Convert.ToInt32(reader["ContatoId"]);
                    comp.Contato = new ContatoDao(Connect.Conectar()).Consultar(id);
                    compromissos.Add(comp);                }
                reader.Close();
                command.ExecuteNonQuery();

                command.Connection = connection;
                return compromissos;
            }
        }
        public Compromisso Consultar(int id)
        {
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM tb_compromissos WHERE Id = @id";
                command.Parameters.Add("id", SqlDbType.Int).Value = id;

                SqlDataReader reader = command.ExecuteReader();
                Compromisso comp = new Compromisso();
                while (reader.Read())
                {
                    comp.Id = Convert.ToInt32(reader["Id"]);
                    comp.Descricao = Convert.ToString(reader["Descricao"]);
                    comp.Data = Convert.ToDateTime(reader["Data"]);
                    var contatoId = Convert.ToInt32(reader["ContatoId"]);
                    comp.Contato = new ContatoDao(Connect.Conectar()).Consultar(contatoId);
                }

                reader.Close();

                command.ExecuteNonQuery();

                command.Connection = connection;
                return comp;
            }
        }
        public bool Alterar(Compromisso compromisso)
        {
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE tb_compromissos SET Descricao = @Descricao, Data = @Data, ContatoId = @ContatoId WHERE Id = @Id";
                command.Parameters.Add("Descricao", SqlDbType.VarChar).Value = compromisso.Descricao;
                command.Parameters.Add("Data", SqlDbType.DateTime).Value = compromisso.Data;
                command.Parameters.Add("ContatoId", SqlDbType.Int).Value = compromisso.Contato.Id;
                command.Parameters.Add("Id", SqlDbType.Int).Value = compromisso.Id;

                command.ExecuteNonQuery();

                command.Connection = connection;
                return true;

            }
        }

        public bool Deletar(Compromisso compromisso)
        {
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = Connect.connectionString;
                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM tb_compromissos WHERE Id = @id";
                command.Parameters.Add("id", SqlDbType.Int).Value = compromisso.Id;

                command.ExecuteNonQuery();

                command.Connection = connection;
                return command.ExecuteNonQuery() > 0;

            }
        }

    }
}
