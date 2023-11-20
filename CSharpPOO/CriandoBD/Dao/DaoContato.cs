using CriandoBD.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoBD.Dao
{
    internal class DaoContato
    {
        public static List<Contato> contatos = new List<Contato>();
        public static bool Salvar(Contato contato)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=agendadb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Contatos([Nome],[Email],[Telefone])VALUES(@Nome,@Email,@Telefone)";
            
                cmd.Parameters.Add("Nome", SqlDbType.VarChar).Value = contato.Nome;
                cmd.Parameters.Add("Email", SqlDbType.VarChar).Value = contato.Email;
                cmd.Parameters.Add("Telefone", SqlDbType.VarChar).Value = contato.Telefone;
            

                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;
            
            }

        }

        public static List<Contato> GetContatos()
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=agendadb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM dbo.Contatos";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contato contato = new Contato();
                    contato.Id = Convert.ToInt32(dr["Id"]);
                    contato.Nome = Convert.ToString(dr["Nome"]);
                    contato.Email = Convert.ToString(dr["Email"]);
                    contato.Telefone = Convert.ToString(dr["Telefone"]);
                    
                    contatos.Add(contato);
                }
                return contatos;
            }
        }

    }
}
