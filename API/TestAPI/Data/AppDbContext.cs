using Microsoft.EntityFrameworkCore;
using TestAPI.Entities;

namespace TestAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt)
        {

        }
        public DbSet<TodoItem> Todos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Compromisso> Compromissos { get; set; }
    }
}
