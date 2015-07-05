namespace MusicSystem.Data.Repositories
{
    using System.Data.Entity;
    using Models;
    using Repository;

    public class SongsRepository : GenericRepository<Song>
    {
        public SongsRepository(DbContext context)
            : base(context)
        {
        }
    }
}
