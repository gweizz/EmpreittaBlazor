using Empreitta.Models;
using Microsoft.EntityFrameworkCore;

namespace Empreitta.Data
{
    public class EmpreittaDbContext : DbContext
    {
        public EmpreittaDbContext(DbContextOptions<EmpreittaDbContext> options)
            : base(options)
        {
        }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<TarefaProfissional> TarefaProfissional { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
