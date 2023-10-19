using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGuideAnimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO guideAnimals (GuideId, AnimalId)\r\nValues (1, 1)\r\nINSERT INTO guideAnimals (GuideId, AnimalId)\r\nValues (1, 2)\r\nINSERT INTO guideAnimals (GuideId, AnimalId)\r\nValues (1, 3)\r\nINSERT INTO guideAnimals (GuideId, AnimalId)\r\nValues (1, 4)\r\n\r\nINSERT INTO guideAnimals (GuideId, AnimalId)\r\nValues (2, 6)\r\n\r\nINSERT INTO guideAnimals (GuideId, AnimalId)\r\nValues (3, 7)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
