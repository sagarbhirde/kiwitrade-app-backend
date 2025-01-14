

using Microsoft.EntityFrameworkCore;

namespace eKiwiTradeApi.Data.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}