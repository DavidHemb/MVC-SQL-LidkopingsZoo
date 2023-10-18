using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    HasHabitat = table.Column<bool>(type: "bit", nullable: false),
                    GuideId = table.Column<int>(type: "int", nullable: true),
                    HabitatId = table.Column<int>(type: "int", nullable: false),
                    AirAnimal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandAnimal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterAnimal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxAltitude = table.Column<int>(type: "int", nullable: true),
                    Speed = table.Column<int>(type: "int", nullable: true),
                    DivingDepth = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Guides_GuideId",
                        column: x => x.GuideId,
                        principalTable: "Guides",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuidesId = table.Column<int>(type: "int", nullable: false),
                    Visitors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Guides_GuidesId",
                        column: x => x.GuidesId,
                        principalTable: "Guides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VisitId",
                table: "AspNetUsers",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_GuideId",
                table: "Animal",
                column: "GuideId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_GuidesId",
                table: "Visits",
                column: "GuidesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Visits_VisitId",
                table: "AspNetUsers",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Visits_VisitId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_VisitId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "AspNetUsers");
        }
    }
}
