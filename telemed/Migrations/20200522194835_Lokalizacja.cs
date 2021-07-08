using Microsoft.EntityFrameworkCore.Migrations;

namespace telemed.Migrations
{
    public partial class Lokalizacja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Temperatures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sensorName",
                table: "Temperatures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "location",
                table: "Temperatures");

            migrationBuilder.DropColumn(
                name: "sensorName",
                table: "Temperatures");
        }
    }
}
