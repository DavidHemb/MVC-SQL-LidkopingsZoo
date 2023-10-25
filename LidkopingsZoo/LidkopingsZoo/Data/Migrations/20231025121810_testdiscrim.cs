using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class testdiscrim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "AirAnimal",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "LandAnimal",
                table: "Animal");

            migrationBuilder.RenameColumn(
                name: "WaterAnimal",
                table: "Animal",
                newName: "AnimalName");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnimalName",
                table: "Animal",
                newName: "WaterAnimal");

            migrationBuilder.AddColumn<string>(
                name: "AirAnimal",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandAnimal",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true);

        }
    }
}
