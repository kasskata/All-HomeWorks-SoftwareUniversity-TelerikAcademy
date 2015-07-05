namespace MusicSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using Models;
    using Repositories;
    using Repository;

    public class MusicSystemData : IMusicSystemData
    {
        private DbContext context;
        private IDictionary<Type, object> repositories;

        public MusicSystemData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get { return (UsersRepository)this.GetRepository<User>(); }
        }

        public IRepository<Album> Albums
        {
            get { return (AlbumsRepository)this.GetRepository<Album>(); }
        }

        public IRepository<Song> Songs
        {
            get { return (SongsRepository)this.GetRepository<Song>(); }
        }

        public IRepository<Artist> Artists
        {
            get { return (ArtistsRepository)this.GetRepository<Artist>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);

            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepo = typeof(GenericRepository<T>);
                if (type.IsAssignableFrom(typeof(User)))
                {
                    typeOfRepo = typeof(UsersRepository);
                }
                else if (type.IsAssignableFrom(typeof(Artist)))
                {
                    typeOfRepo = typeof(ArtistsRepository);
                }
                else if (type.IsAssignableFrom(typeof(Album)))
                {
                    typeOfRepo = typeof(AlbumsRepository);
                }
                else if (type.IsAssignableFrom(typeof(Song)))
                {
                    typeOfRepo = typeof(SongsRepository);
                }

                var repo = Activator.CreateInstance(typeOfRepo, this.context);
                this.repositories.Add(type, repo);
            }

            return (GenericRepository<T>)this.repositories[type];
        }
    }
}
