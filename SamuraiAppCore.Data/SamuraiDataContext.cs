using SamuraiAppCore.Domains;
using Microsoft.EntityFrameworkCore;

namespace SamuraiAppCore.Data
{
    public class SamuraiDataContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Buttle> Buttles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<SamuraiButtle> SamuraiButtles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiButtle>().HasKey(c => new { c.ButtleId, c.SamuraiId });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SamuraiDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
