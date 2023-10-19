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
            migrationBuilder.Sql("INSERT INTO Guides (name)\r\nVALUES ('Guido The Guide')\r\n\r\nINSERT INTO Guides (name)\r\nVALUES ('Ace Ventura')\r\n\r\nINSERT INTO Guides (name)\r\nVALUES ('Crocodile Dundee')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
