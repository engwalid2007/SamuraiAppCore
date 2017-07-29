using SamuraiAppCore.Domains;
using Microsoft.EntityFrameworkCore;

namespace SamuraiAppCore.Data
{
    public class SamuraiDataContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Buttle> Buttles { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SamuraiDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
