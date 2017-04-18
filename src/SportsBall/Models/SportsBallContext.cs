using Microsoft.EntityFrameworkCore;

namespace SportsBall.Models
{
    public class SportsBallContext : DbContext
    {
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=sportsball;integrated security=True");
        }
    }
}
