using Microsoft.EntityFrameworkCore;
using Trznica.Models;

namespace Trznica.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        //public AppDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Trznica;Trusted_Connection=True");
        }

        public DbSet<VrstaStola> VrstaStola { get; set; }

        public DbSet<Stol>Stol { get; set; }

        public DbSet<Korisnik> Korisnik { get; set; }

        public DbSet<ZahtjevUgovor> ZahtjevUgovor {  get; set; }

        public DbSet<Racun> Racun { get; set; }

        public DbSet<Ugovor> Ugovor { get; set; }
    }
}
