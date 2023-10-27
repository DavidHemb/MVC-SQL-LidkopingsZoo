using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGuides : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Guides (name, Email)\r\nVALUES ('Guido The Guide', 'GuidoTheGuide@mail.com')\r\n\r\nINSERT INTO Guides (name, Email)\r\nVALUES ('Ace Ventura', 'AceVentura@mail.com')\r\n\r\nINSERT INTO Guides (name, Email)\r\nVALUES ('Crocodile Dundee', 'CrocodileDundee@mail.com')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
