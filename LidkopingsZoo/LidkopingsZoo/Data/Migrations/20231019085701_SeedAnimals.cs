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
            migrationBuilder.Sql("INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Palle', 'Snel Hest', 19, 1,2, 'Cow','','',0,0,0)\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Kalle', 'Fest Hest', 4, 1,2, 'Cow','','',0,0,0)\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Ralle', 'Cool Hest', 33, 1,2, 'Cow','','',0,0,0)\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Salle', 'Ko Hest', 22, 1,2, 'Cow','','',0,0,0)\r\n\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Krakis', 'Stor Bläckfisk', 432, 1,3, 'Kraken','','',0,0,0)\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Willy', 'Cute Killer', 133, 1,3, 'Orca','','',0,0,0)\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Pingu', 'TOTOTO', 11, 1,3, 'Penguin','','',0,0,0)\r\n\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Smaug', 'Hides In The Mountain', 11, 1,1, 'Dragon','','',0,0,0)\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Scrooge', 'Flips a coin', 11, 1,1, 'Goose','','',0,0,0)\r\nINSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)\r\nVALUES ('Gryffen', 'FlaxFlaxFlax', 11, 1,1, 'Griffin','','',0,0,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
