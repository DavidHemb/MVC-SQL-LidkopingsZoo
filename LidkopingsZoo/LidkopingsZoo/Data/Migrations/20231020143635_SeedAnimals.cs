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
            migrationBuilder.Sql("INSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Palle', 'Snel Hest', 19, 2, 'Cow','','',0,0,0, 'Cow')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Kalle', 'Fest Hest', 4, 2, 'Cow','','',0,0,0, 'Cow')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Ralle', 'Cool Hest', 33, 2, 'Cow','','',0,0,0, 'Cow')\r\nINSERT INTO Animal (name, Description, Age, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Salle', 'Ko Hest', 22, 2, 'Cow','','',0,0,0,'Cow')\r\n\r\nINSERT INTO Animal (name, Description, Age, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Krakis', 'Stor Bläckfisk', 432, 3, 'Kraken','','',0,0,0,'Kraken')\r\nINSERT INTO Animal (name, Description, Age, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Willy', 'Cute Killer', 133, 3, 'Orca','','',0,0,0, 'Orca')\r\nINSERT INTO Animal (name, Description, Age, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Pingu', 'TOTOTO', 11, 3, 'Penguin','','',0,0,0, 'Penguin')\r\n\r\nINSERT INTO Animal (name, Description, Age, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Smaug', 'Hides In The Mountain', 11, 1, 'Dragon','','',0,0,0,'Dragon')\r\nINSERT INTO Animal (name, Description, Age, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Scrooge', 'Flips a coin', 11, 1, 'Goose','','',0,0,0,'Goose')\r\nINSERT INTO Animal (name, Description, Age, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth, SpeciesName)\r\nVALUES ('Gryffen', 'FlaxFlaxFlax', 11, 1, 'Griffin','','',0,0,0,'Griffin')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
