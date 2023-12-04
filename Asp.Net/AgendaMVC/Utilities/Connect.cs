using System.Data.SqlClient;

namespace AgendaMVC.Utilities
{
    public class Connect
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\DBAgenda.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection Conectar()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\DBAgenda.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;


        }
    }
}
