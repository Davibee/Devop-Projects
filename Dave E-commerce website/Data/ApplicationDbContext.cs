using Dave_E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Dave_E_commerce_website.Data;

public class ApplicationDbContext : IdentityDbContext
{

    public DbSet<Category> category { get; set; }
    public DbSet<Product> product { get; set; }
    public DbSet<Picture> picture { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder                
                 .UseSqlite("Data Source=app.db");
        }
    }

    public ApplicationDbContext()
    {
    }
}

