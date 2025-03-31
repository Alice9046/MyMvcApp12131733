using Microsoft.EntityFrameworkCore;
using MyMvcApp12131733.Models;

namespace MyMvcApp12131733.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=ep-green-glitter-a1mjq5d0-pooler.ap-southeast-1.aws.neon.tech;Database=mydb;Username=mydb_owner;Password=npg_Nhjn8mWXUFK4;SSL Mode=Require;Trust Server Certificate=true");
            }
        }
    }
}