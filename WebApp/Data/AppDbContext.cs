using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{

    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 @"Server=AZIMZADA;Database=CreativeDB;Trusted_Connection=true;TrustServerCertificate=True;"
                                 );
        }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Service> Services { get; set; }

    }
}
