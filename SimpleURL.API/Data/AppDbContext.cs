using Microsoft.EntityFrameworkCore;
using SimpleURL.Models;

namespace SimpleURL.Data.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Url> Urls { get; set; }
    
}