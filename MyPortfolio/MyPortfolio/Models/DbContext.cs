/*using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;

public class MyPortfolioContext : DbContext
{
    public DbSet<WorkExperience> WorkExperiences { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkExperience>().ToTable("WorkExperiences");
    }

    // Configure your database connection here
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True");
    }

    internal void AddWorkExperiencesToDatabase()
    {
        throw new NotImplementedException();
    }
}
*/