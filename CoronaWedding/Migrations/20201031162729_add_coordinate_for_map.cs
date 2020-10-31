using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaWedding.Migrations
{
    public partial class add_coordinate_for_map : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "map",
                table: "Location");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Location",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Location",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Location");

            migrationBuilder.AddColumn<string>(
                name: "map",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
