using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlazorServerLAP.Models.Configurations;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Person => Set<Person>();
    public DbSet<Campus> Campus => Set<Campus>();
    public DbSet<PersonCampus> PersonCampus => Set<PersonCampus>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
