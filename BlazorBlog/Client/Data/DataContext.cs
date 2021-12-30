using BlazorBlog.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorBlog.Client.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
