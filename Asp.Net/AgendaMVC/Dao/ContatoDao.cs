using AgendaMVC.Interfaces;
using AgendaMVC.Models;
using System.Data;
using System.Data.SqlClient;

namespace AgendaMVC.Dao
{
    public class ContatoDao : ICrud<Contato>
    {
        private SqlConnection connection;
        
        public ContatoDao()
        {
        }
        public ContatoDao(SqlConnection connection) { 
        
            this.connection = connection;
        }

        public bool Salvar(Contato contato)
        {
            using (connection)
            {
                connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\victor.eisenhut\\Documents\\DBAgenda.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand command = connection.CreateCommand();

                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO tb_contatos(nome,email,celular)VALUES(@nome,@email,@celular)";

                command.Parameters.Add("nome", SqlDbType.VarChar).Value = contato.Nome;
                command.Parameters.Add("email", SqlDbType.VarChar).Value = contato.Email;
                command.Parameters.Add("celular", SqlDbType.VarChar).Value = contato.Fone;
                command.ExecuteNonQuery();

                command.Connection = connection;
                return true;
            }
        }

    }
}
