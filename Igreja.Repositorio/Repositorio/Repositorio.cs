using Igreja.Dominio.Abstracao.Repositorio;
using System.Data.Entity;
using System.Linq;

namespace Igreja.Repositorio.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected readonly ApplicationDbContext Db;

        public Repositorio(ApplicationDbContext db)
        {
            Db = db;
        }

        public T FindById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return Db.Set<T>();
        }

        public int Insert(T entity)
        {
            Db.Set<T>().Add(entity);
            return Db.SaveChanges();
        }

        public int Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            return Db.SaveChanges();
        }
    }
}
