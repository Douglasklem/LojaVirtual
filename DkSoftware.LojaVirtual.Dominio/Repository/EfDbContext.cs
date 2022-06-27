using DkSoftware.LojaVirtual.Dominio.Entidade;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DkSoftware.LojaVirtual.Dominio.Repository
{
    public class EfDbContext : DbContext
    {        
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {          
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("PRODUTOS");
            modelBuilder.HasDefaultSchema("SYSTEM");
        }
    }
}
