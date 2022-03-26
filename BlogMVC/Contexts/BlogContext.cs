using System.Data.Entity;

namespace BlogMVC.Models
{
    public class BlogContext:DbContext
    {

        public BlogContext():base("BlogDB")
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
