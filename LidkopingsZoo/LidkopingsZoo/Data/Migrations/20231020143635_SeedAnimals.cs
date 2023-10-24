using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, Speed, SpeciesName)\r\nVALUES ('Palle', 'Snel Hest', 19, 2, 'Cow', 27,'Cow')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, Speed, SpeciesName)\r\nVALUES ('Kalle', 'Fest Hest', 4, 2, 'Cow', 27,'Cow')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, Speed, SpeciesName)\r\nVALUES ('Ralle', 'Cool Hest', 33, 2, 'Cow', 27,'Cow')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, Speed, SpeciesName)\r\nVALUES ('Salle', 'Ko Hest', 22, 2, 'Cow', 27,'Cow')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, Speed, SpeciesName)\r\nVALUES ('Santa', 'Flying maniac', 1751, 2, 'SantaClaus', 539626424,'SantaClaus')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, Speed, SpeciesName)\r\nVALUES ('Giga', 'Giant dinosoar', 68000000, 2, 'Giganotosaurus', 50,'Giganotosaurus')\r\n\r\nINSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, DivingDepth, SpeciesName)\r\nVALUES ('Krakis', 'Stor Bläckfisk', 432, 3, 'Kraken', 10500, 'Kraken')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, DivingDepth, SpeciesName)\r\nVALUES ('Willy', 'Cute Killer', 133, 3, 'Orca', 1087,'Orca')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, DivingDepth, SpeciesName)\r\nVALUES ('Pingu', 'TOTOTO', 11, 3, 'Penguin', 300, 'Penguin')\r\n\r\nINSERT INTO Animal (name, Description, Age, HabitatId, AirAnimal, MaxAltitude, SpeciesName)\r\nVALUES ('Smaug', 'Hides In The Mountain', 11, 1, 'Dragon', 7000,'Dragon')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, AirAnimal, MaxAltitude, SpeciesName)\r\nVALUES ('Scrooge', 'Flips a coin', 11, 1, 'Goose', 8800, 'Goose')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, AirAnimal, MaxAltitude, SpeciesName)\r\nVALUES ('Gryffen', 'FlaxFlaxFlax', 11, 1, 'Griffin', 4000,'Griffin')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
