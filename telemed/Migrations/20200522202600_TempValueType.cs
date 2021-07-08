using Microsoft.EntityFrameworkCore.Migrations;

namespace telemed.Migrations
{
    public partial class TempValueType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "value",
                table: "Temperatures",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "value",
                table: "Temperatures",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
