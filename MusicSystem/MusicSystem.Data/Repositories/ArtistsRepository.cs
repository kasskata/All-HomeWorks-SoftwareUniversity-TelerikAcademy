namespace MusicSystem.Data.Repositories
{
    using System.Data.Entity;
    using Models;
    using Repository;

    public class ArtistsRepository : GenericRepository<Artist>
    {
        public ArtistsRepository(DbContext context)
            : base(context)
        {
        }
    }
}
