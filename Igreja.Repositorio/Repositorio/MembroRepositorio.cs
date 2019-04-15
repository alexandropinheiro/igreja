using Igreja.Dominio.Abstracao.Repositorio;
using Igreja.Dominio.Entidades;

namespace Igreja.Repositorio.Repositorio
{
    public class MembroRepositorio : Repositorio<Membro>, IMembroRepositorio
    {
        public MembroRepositorio(ApplicationDbContext db) : base(db)
        {
        }
    }
}
