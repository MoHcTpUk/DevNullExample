using DevNullExample.Public.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DevNullExample.Public.Infrastructure.EF
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<WeatherForecast> WeatherForecast { get; set; } = null;
    }
}