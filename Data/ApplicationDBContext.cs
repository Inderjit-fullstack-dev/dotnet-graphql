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
    }
}
