using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaWedding.Migrations
{
    public partial class supplierEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "supplierEmail",
                table: "Photographer");

            migrationBuilder.DropColumn(
                name: "supplierEmail",
                table: "Music");

            migrationBuilder.AddColumn<string>(
                name: "supplierEmail",
                table: "Photographer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "supplierEmail",
                table: "Music",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Kosher",
                table: "Catering",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "supplierEmail",
                table: "Photographer");

            migrationBuilder.DropColumn(
                name: "supplierEmail",
                table: "Music");

            migrationBuilder.AddColumn<string>(
                name: "supplierEmail",
                table: "Photographer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "supplierEmail",
                table: "Music",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Kosher",
                table: "Catering",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
