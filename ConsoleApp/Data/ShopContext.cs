using ConsoleApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
           //Database.EnsureDeleted();
            Database.EnsureCreated();            
        }

        public DbSet<Sock> Socks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=COMPUTER;Database=Shop;Trusted_Connection=True;");
            //optionsBuilder.UseNpgsql("");
        }
    }
}
