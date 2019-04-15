using Igreja.Dominio.Entidades;
using Igreja.Repositorio.Configurations;
using System.Data.Entity;

namespace Igreja.Repositorio.Repositorio
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("teste")
        {
        }

        public DbSet<Membro> Membros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MembroMappingConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
