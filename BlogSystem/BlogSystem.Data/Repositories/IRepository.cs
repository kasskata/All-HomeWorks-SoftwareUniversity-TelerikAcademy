using System.Data.Entity;
using System.Linq;

namespace BlogSystem.Data
{
    public interface IRepository<T> where T : class
    {
        IDbSet<T> Set { get; }

        //Create
        void Add(T entity);

        //Read
        T Get(object id);
        IQueryable<T> All();

        //Update
        void Update(T entity);
        T Update(object id);

        //Delete
        T Delete(object id);
        void Delete(T entity);

        //SaveChanges
        int SaveChanges();
    }
}
