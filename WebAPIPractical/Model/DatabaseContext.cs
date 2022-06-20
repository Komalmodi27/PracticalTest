using Microsoft.EntityFrameworkCore;

namespace WebAPIPractical.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("Article")
                .HasKey(x => x.BlogId);
            });
        }
    }
}
