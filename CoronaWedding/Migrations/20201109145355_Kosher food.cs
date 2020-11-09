using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaWedding.Migrations
{
    public partial class Kosherfood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kosher",
                table: "Catering",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kosher",
                table: "Catering");
        }
    }
}
