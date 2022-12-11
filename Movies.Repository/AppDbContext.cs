using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Movies.DTO;

namespace Movies.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        private static IConfigurationRoot _configuration;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                string cnstr = _configuration.GetConnectionString("ProductionDatabase");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }
    }
}