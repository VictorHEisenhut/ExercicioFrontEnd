using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Data
{
    public class ProjetoMVCContext : DbContext
    {
        public ProjetoMVCContext (DbContextOptions<ProjetoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoMVC.Models.Produto> Produto { get; set; } = default!;
    }
}
