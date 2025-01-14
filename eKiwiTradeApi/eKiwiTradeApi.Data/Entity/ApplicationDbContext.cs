

using Microsoft.EntityFrameworkCore;

namespace eKiwiTradeApi.Data.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    public DbSet<Category> Categories { get; set; }
    public DbSet<GroupEntity> Groups { get; set; }
    public DbSet<TypeEntity> Types { get; set; }

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

              // Configure the Group table
        //     modelBuilder.Entity<GroupEntity>(entity =>
        //     {
        //         entity.ToTable("Group"); // Table name
        //         entity.HasKey(e => e.GroupId); // Primary key
        //         entity.Property(e => e.GroupId).HasColumnName("groupid");
        //         entity.Property(e => e.GroupName).HasColumnName("groupname").IsRequired().HasMaxLength(100);
        //         entity.Property(e => e.CategoryId).HasColumnName("categoryid");
        //         entity.HasOne(e => e.Category)
        //               .WithMany()
        //               .HasForeignKey(e => e.CategoryId)
        //               .OnDelete(DeleteBehavior.Cascade);
        //     });

        //     // Configure the Type table
        //     modelBuilder.Entity<TypeEntity>(entity =>
        //     {
        //         entity.ToTable("Type"); // Table name
        //         entity.HasKey(e => e.TypeId); // Primary key
        //         entity.Property(e => e.TypeId).HasColumnName("typeid");
        //         entity.Property(e => e.TypeName).HasColumnName("typename").IsRequired();
        //         entity.Property(e => e.GroupId).HasColumnName("groupid");
        //         entity.Property(e => e.CategoryId).HasColumnName("categoryid");
        //         entity.HasOne(e => e.Group)
        //               .WithMany()
        //               .HasForeignKey(e => e.GroupId)
        //               .OnDelete(DeleteBehavior.Cascade);
        //         entity.HasOne(e => e.Category)
        //               .WithMany()
        //               .HasForeignKey(e => e.CategoryId)
        //               .OnDelete(DeleteBehavior.Cascade);
        //     });
        // }
        }
    }
}