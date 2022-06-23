using delfimLogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace delfimLogAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Rastreio> Rastreios { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
       


    }
}
