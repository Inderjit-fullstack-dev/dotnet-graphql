using DotnetWithGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetWithGraphQL.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Submenu> Submenus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
