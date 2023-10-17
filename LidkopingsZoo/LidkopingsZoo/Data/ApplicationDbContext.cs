using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Elements;
using LidkopingsZoo.Models.Animals.LandAnimals;
using LidkopingsZoo.Models.Animals.WaterAnimals;
using LidkopingsZoo.Models.Animals.AirAnimals;
using LidkopingsZoo.Models.Visitation;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics.Contracts;

namespace LidkopingsZoo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Guide> Guides { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
               .HasDiscriminator<bool>("HasHabitat")
               .HasValue<Habitat>(true);

            modelBuilder.Entity<Habitat>()
                .HasDiscriminator<string>("HabitatType")
                .HasValue<Air>("Air")
                .HasValue<Land>("Land")
                .HasValue<Water>("Water");

            modelBuilder.Entity<Air>()
                .HasDiscriminator<string>("AirType")?
                .HasValue<Dragon>("Dragon")
                .HasValue<Goose>("Goose")
                .HasValue<Griffin>("Griffin");

            modelBuilder.Entity<Land>()
                .HasDiscriminator<string>("LandType")
                .HasValue<Cow>("Cow")?
                .HasValue<Giganotosaurus>("Giganotosaurus")
                .HasValue<SantaClaus>("SantaClaus");

            modelBuilder.Entity<Water>()
                .HasDiscriminator<string>("WaterType")
                .HasValue<Kraken>("Kraken")
                .HasValue<Orca>("Orca")
                .HasValue<Penguin>("Penguin");

            base.OnModelCreating(modelBuilder);
        }
    }
}