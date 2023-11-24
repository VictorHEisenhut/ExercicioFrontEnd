using CriandoBD.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CriandoBD.Dao
{
    internal class DaoLocais
    {
        public static List<Locais> locais = new();

        public static bool Salvar(Locais local)
        {
            using (SqlConnection connection = new())
            {
                //Abrindo connection
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\agendaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                //Adicionando linha de comando e comandos
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Locais([Cidade],[Bairro],[Rua],[Numero],[Cep])VALUES(@Cidade,@Bairro,@Rua, @Numero, @Cep)";

                //Adicionando parâmetros
                cmd.Parameters.Add("Cidade", SqlDbType.VarChar).Value = local.Cidade;
                cmd.Parameters.Add("Bairro", SqlDbType.VarChar).Value = local.Bairro ;
                cmd.Parameters.Add("Rua", SqlDbType.VarChar).Value = local.Rua ;
                cmd.Parameters.Add("Numero", SqlDbType.Int).Value = local.Numero;
                cmd.Parameters.Add("Cep", SqlDbType.VarChar).Value = local.Cep;


                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public static List<Locais> GetLocais()
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=agendadb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM dbo.Locais";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Locais local = new Locais();
                    local.Id = Convert.ToInt32(dr["Id"]);
                    local.Cidade = Convert.ToString(dr["Cidade"]);
                    local.Bairro = Convert.ToString(dr["Bairro"]);
                    local.Rua = Convert.ToString(dr["Rua"]);
                    local.Numero = Convert.ToInt32(dr["Numero"]);
                    local.Cep = Convert.ToString(dr["Cep"]);

                    locais.Add(local);
                }
                return locais;

            }
            
        }
    }
}
