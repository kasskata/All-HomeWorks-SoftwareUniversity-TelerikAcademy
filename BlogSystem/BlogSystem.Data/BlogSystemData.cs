using System.Data.Entity;
using BlogSystem.Models;

namespace BlogSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class BlogSystemData : IBlogSystemData
    {
        private DbContext context;
        private IDictionary<Type, object> repositories;

        public BlogSystemData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IRepository<Comment> Comments
        {
            get { return this.GetRepository<Comment>(); }
        }

        public IRepository<Post> Posts
        {
            get { return this.GetRepository<Post>(); }
        }

        public IRepository<Tag> Tags
        {
            get { return this.GetRepository<Tag>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepo = typeof(T);

            if (!this.repositories.ContainsKey(typeOfRepo))
            {
                var repo = Activator.CreateInstance(typeof(GenericRepository<T>), this.context);
                this.repositories.Add(typeOfRepo, repo);
            }

            return (IRepository<T>)this.repositories[typeOfRepo];
        }
    }
}
