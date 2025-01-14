

using Microsoft.EntityFrameworkCore;

namespace eKiwiTradeApi.Data.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// Configure the Category table if necessary
            //modelBuilder.Entity<Category>(entity =>
            //{
            //    entity.ToTable("categories"); // PostgreSQL table name
            //    entity.HasKey(e => e.Categoryid); // Primary key
            //    entity.Property(e => e.CategoryName).IsRequired().HasMaxLength(255);
            //});
        }
    }
}