using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FEA.Models.DbContext;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Country.Country> Countries { get; set; }
    public DbSet<City.City> Cities { get; set; }
    public DbSet<Hotel.Hotel> Hotels { get; set; }

}