namespace MusicSystem.Data.Repository
{
    using System.Linq;

    public interface IRepository<T>
    {
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
