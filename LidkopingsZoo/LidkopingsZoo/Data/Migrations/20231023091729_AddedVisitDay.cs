using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidkopingsZoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedVisitDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VisitDay",
                table: "Visits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisitDay",
                table: "Visits");
        }
    }
}
