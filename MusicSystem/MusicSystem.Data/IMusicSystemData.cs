namespace MusicSystem.Data
{
    using Models;
    using Repository;

    public interface IMusicSystemData
    {
        IRepository<User> Users { get; }

        IRepository<Artist> Artists { get; }

        IRepository<Album> Albums { get; }

        IRepository<Song> Songs { get; }

        int SaveChanges();
    }
}
