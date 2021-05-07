using FantasyFootballWebLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyFootballLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {

        //MAPPING OUT THE DATABASE
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        //public DbSet<Vet> Vets { get; set; }
        //public DbSet<Visit> Visits { get; set; }



    }
}

