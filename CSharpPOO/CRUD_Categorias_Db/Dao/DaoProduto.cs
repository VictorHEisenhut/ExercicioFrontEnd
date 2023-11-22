using CRUD_Categorias_Db.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Categorias_Db.Dao
{
    internal class DaoProduto
    {
        public static bool Salvar(Produto produto)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tb_produtos([Nome],[ValorUnit],[Estoque],[CategoriaID])VALUES(@Nome, @ValorUnit, @Estoque, @CategoriaID)";

                cmd.Parameters.Add("Nome", SqlDbType.VarChar).Value = produto.Nome;
                cmd.Parameters.Add("ValorUnit", SqlDbType.Decimal).Value = produto.ValorUnit;
                cmd.Parameters.Add("Estoque", SqlDbType.Int).Value = produto.Estoque;
                cmd.Parameters.Add("CategoriaID", SqlDbType.Int).Value = produto.Categoria.Id;

                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public static List<Produto> GetProdutos()
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tb_produtos";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dr["Id"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.ValorUnit = Convert.ToDouble(dr["ValorUnit"]);
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                    var catID = Convert.ToInt32(dr["CategoriaID"]);
                    produto.Categoria = DaoCategoria.GetCategoriaByID(catID);

                    produtos.Add(produto);
                }
                return produtos;
            }
        }
        public static Produto GetProdutoByID(int id)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM tb_produtos WHERE ID = {id}";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dr["Id"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.ValorUnit = Convert.ToDouble(dr["ValorUnit"]);
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                    var catID = Convert.ToInt32(dr["CategoriaID"]);
                    produto.Categoria = DaoCategoria.GetCategoriaByID(catID);

                    return produto;
                }
                return null;
            }
        }

        public static List<Produto> GetProdutoByCategoria(int categoriaId)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM tb_produtos WHERE CategoriaID = {categoriaId}";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dr["Id"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.ValorUnit = Convert.ToDouble(dr["ValorUnit"]);
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                    var catID = Convert.ToInt32(dr["CategoriaID"]);
                    produto.Categoria = DaoCategoria.GetCategoriaByID(catID);

                    produtos.Add(produto);
                }
                return produtos;
            }
        }

        public static bool Update(Produto produto, Produto newProduto)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"UPDATE tb_produtos SET Nome = '{newProduto.Nome}', ValorUnit = '{newProduto.ValorUnit}', Estoque = '{newProduto.Estoque}', CategoriaID = '{newProduto.Categoria.Id}' WHERE Id = '{produto.Id}'";
                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public static bool Delete(Produto produto)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"DELETE FROM tb_produtos WHERE Id='{produto.Id}'";
                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }
        }
    }
}
