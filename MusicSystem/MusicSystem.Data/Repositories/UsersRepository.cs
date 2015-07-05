namespace MusicSystem.Data.Repositories
{
    using System.Data.Entity;
    using Models;
    using Repository;

    public class UsersRepository : GenericRepository<User>
    {
        public UsersRepository(DbContext context)
            : base(context)
        {
        }
    }
}
