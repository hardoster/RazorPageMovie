using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=COSASE-OPGPS2\\SQLEXPRESS;Database=registro;Integrated Security=True;");
        }
    }
}
