using Igreja.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Igreja.Repositorio.Configurations
{
    public class MembroMappingConfiguration : EntityTypeConfiguration<Membro>
    {
        public MembroMappingConfiguration()
        {
            ToTable("Membro");
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).IsRequired().HasColumnType("VARCHAR");            
        }
    }
}
