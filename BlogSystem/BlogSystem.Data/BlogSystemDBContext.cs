namespace BlogSystem.Data
{
    using System.Data.Entity;
    using Models;

    public class BlogSystemDBContext : DbContext
    {
        public BlogSystemDBContext()
            : base("BlogSystem")
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
