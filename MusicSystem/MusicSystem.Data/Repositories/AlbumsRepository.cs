namespace MusicSystem.Data.Repositories
{
    using System.Data.Entity;
    using Models;
    using Repository;

    public class AlbumsRepository : GenericRepository<Album>
    {
        public AlbumsRepository(DbContext context)
            : base(context)
        {
        }
    }
}
