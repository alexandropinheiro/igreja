using System.Linq;

namespace Igreja.Dominio.Abstracao.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        IQueryable<T> GetAll();
        T FindById(int id);
        int Insert(T entity);
        int Update(T entity);
    }
}
