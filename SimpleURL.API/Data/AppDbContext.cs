using Microsoft.EntityFrameworkCore;
using SimpleURL.API.Models;

namespace SimpleURL.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }

        public DbSet<Url> Urls { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=SimpleURL;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
          
    
    }
}