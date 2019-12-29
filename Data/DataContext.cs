using Microsoft.EntityFrameworkCore;
using GameAPI.Models;

namespace GameAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Movement> Movements { get; set; }

        public DbSet<Position> Positions { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasMany(s => s.matrix).WithOne();
        }

    }
}