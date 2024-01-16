using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Data.Common;

namespace CategoriaAPI.Data
{
    public class CategoriaContext : DbContext
    {
        public CategoriaContext(DbContextOptions<CategoriaContext> opt) : base(opt)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.eisenhut\Documents\categoriaDb.mdf;Integrated Security=True;Connect Timeout=30";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
