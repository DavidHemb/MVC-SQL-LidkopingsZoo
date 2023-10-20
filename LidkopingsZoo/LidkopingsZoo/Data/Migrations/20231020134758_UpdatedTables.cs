using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasHabitat",
                table: "Animal");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpeciesName",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Guides");

            migrationBuilder.DropColumn(
                name: "SpeciesName",
                table: "Animal");

            migrationBuilder.AddColumn<bool>(
                name: "HasHabitat",
                table: "Animal",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
