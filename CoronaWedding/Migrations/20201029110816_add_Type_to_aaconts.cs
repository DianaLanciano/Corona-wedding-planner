using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaWedding.Migrations
{
    public partial class add_Type_to_aaconts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Music",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Account",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Music");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Account");
        }
    }
}
