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
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<GuideAnimal> guideAnimals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habitat>()
                .HasDiscriminator<int>("HabitatId")
                .HasValue<Air>(1)
                .HasValue<Land>(2)
                .HasValue<Water>(3);

            modelBuilder.Entity<GuideAnimal>()
                .HasKey(ba => new { ba.AnimalId, ba.GuideId });

            modelBuilder.Entity<Air>()
                .HasDiscriminator<string>("AirAnimal")?
                .HasValue<Dragon>("Dragon")
                .HasValue<Goose>("Goose")
                .HasValue<Griffin>("Griffin");

            modelBuilder.Entity<Land>()
                .HasDiscriminator<string>("LandAnimal")?
                .HasValue<Cow>("Cow")
                .HasValue<Giganotosaurus>("Giganotosaurus")
                .HasValue<SantaClaus>("SantaClaus");

            modelBuilder.Entity<Water>()
                .HasDiscriminator<string>("WaterAnimal")?
                .HasValue<Kraken>("Kraken")
                .HasValue<Orca>("Orca")
                .HasValue<Penguin>("Penguin");

            base.OnModelCreating(modelBuilder);
        }
    }
}