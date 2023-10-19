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
            migrationBuilder.Sql("INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal)\r\nVALUES ('Palle', 'Snel Hest', 19, 1,2, 'Cow')\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,LandAnimal)\r\nVALUES ('Kalle', 'Fest Hest', 4, 1,2, 'Cow')\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,LandAnimal)\r\nVALUES ('Ralle', 'Cool Hest', 33, 1,2, 'Cow')\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,LandAnimal)\r\nVALUES ('Salle', 'Ko Hest', 22, 1,2, 'Cow')\r\n\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal)\r\nVALUES ('Krakis', 'Stor Bläckfisk', 432, 1,3, 'Kraken')\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal)\r\nVALUES ('Willy', 'Cute Killer', 133, 1,3, 'Orca')\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal)\r\nVALUES ('Pingu', 'TOTOTO', 11, 1,3, 'Penguin')\r\n\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal)\r\nVALUES ('Smaug', 'Hides In The Mountain', 11, 1,1, 'Dragon')\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal)\r\nVALUES ('Scrooge', 'Flips a coin', 11, 1,1, 'Goose')\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal)\r\nVALUES ('Gryffen', 'FlaxFlaxFlax', 11, 1,1, 'Griffin')\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
