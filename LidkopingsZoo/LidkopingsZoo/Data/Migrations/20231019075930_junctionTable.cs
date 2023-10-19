using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class junctionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guides_Animal_AnimalsId",
                table: "Guides");

            migrationBuilder.DropIndex(
                name: "IX_Guides_AnimalsId",
                table: "Guides");

            migrationBuilder.DropColumn(
                name: "AnimalsId",
                table: "Guides");

            migrationBuilder.CreateTable(
                name: "guideAnimals",
                columns: table => new
                {
                    GuideId = table.Column<int>(type: "int", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guideAnimals", x => new { x.AnimalId, x.GuideId });
                    table.ForeignKey(
                        name: "FK_guideAnimals_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_guideAnimals_Guides_GuideId",
                        column: x => x.GuideId,
                        principalTable: "Guides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_guideAnimals_GuideId",
                table: "guideAnimals",
                column: "GuideId",
                unique: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "guideAnimals");

            migrationBuilder.AddColumn<int>(
                name: "AnimalsId",
                table: "Guides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Guides_AnimalsId",
                table: "Guides",
                column: "AnimalsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guides_Animal_AnimalsId",
                table: "Guides",
                column: "AnimalsId",
                principalTable: "Animal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
