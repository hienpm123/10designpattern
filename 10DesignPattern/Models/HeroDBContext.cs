using Microsoft.EntityFrameworkCore;

namespace _10DesignPattern.Models
{
    public class HeroDBContext : DbContext
    {
        public DbSet<Characters>? Characters { get; set; }
        public DbSet<Ranks>? Ranks { get; set; }
        public HeroDBContext(DbContextOptions<HeroDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map entities to tables  
            modelBuilder.Entity<Characters>().ToTable("UserGroups");
            modelBuilder.Entity<Ranks>().ToTable("Users");

            modelBuilder.Entity<Characters>().HasKey(ug => ug.Id).HasName("PK_Characters");
            modelBuilder.Entity<Ranks>().HasKey(u => u.Id).HasName("PK_Ranks");
        }
    }
}
