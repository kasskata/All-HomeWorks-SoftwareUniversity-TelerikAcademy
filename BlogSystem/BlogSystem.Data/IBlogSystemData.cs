namespace BlogSystem.Data
{
    using Models;

    public interface IBlogSystemData
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Post> Posts { get; }

        IRepository<Tag> Tags { get; }

        int SaveChanges();
    }
}
