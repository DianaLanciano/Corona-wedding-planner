using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaWedding.Migrations
{
    public partial class add_the_item_ids_for_cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CateringId",
                table: "Account",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Account",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MusicId",
                table: "Account",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhotographerId",
                table: "Account",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CateringId",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "MusicId",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "PhotographerId",
                table: "Account");
        }
    }
}
