using CRUD_Categorias_Db.Entidades;
using CRUD_Categorias_Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Categorias_Db.Dao
{
    internal class DaoCategoria : IDaoCrud<Categoria>
    {
       // private static List<Categoria> categorias = new List<Categoria>();
        public bool Salvar(Categoria t)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tb_categorias([Descricao])VALUES(@Descricao)";

                cmd.Parameters.Add("Descricao", SqlDbType.VarChar).Value = t.Descricao;

                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public List<Categoria> GetItens()
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tb_categorias";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                List<Categoria> categorias = new List<Categoria>();
                while (dr.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(dr["Id"]);
                    categoria.Descricao = Convert.ToString(dr["Descricao"]);

                    categorias.Add(categoria);
                }
                return categorias;
            }
        }

        public Categoria GetItemByID(int id)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM tb_categorias WHERE Id = '{id}'";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(dr["Id"]);
                    categoria.Descricao = Convert.ToString(dr["Descricao"]);

                    return categoria;
                }
                return null;
            }
        }

        public bool Update(Categoria t)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"UPDATE tb_categorias SET Descricao = @Descricao WHERE Id = @ID";
                cmd.Parameters.Add("Descricao", SqlDbType.VarChar).Value = t.Descricao;
                cmd.Parameters.Add("ID", SqlDbType.Int).Value = t.Id;

                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public bool Delete(Categoria t)
        {
            using (SqlConnection connection = new())
            {
                try
                {
                    connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"DELETE FROM tb_categorias WHERE Id='{t.Id}'";
                    cmd.Connection = connection;
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (SqlException)
                {
                    Console.WriteLine("Categoria já está atribuída a um produto!");
                    return false;
                }

            }
        }

    }
}
