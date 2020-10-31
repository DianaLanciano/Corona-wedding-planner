using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaWedding.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(nullable: true),
                    weddingDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Catering",
                columns: table => new
                {
                    CateringId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foodType = table.Column<string>(nullable: true),
                    supplireEmail = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    imagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catering", x => x.CateringId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placeCapacity = table.Column<int>(nullable: false),
                    supplireEmail = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    map = table.Column<string>(nullable: true),
                    imagePath = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    MusicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    musicType = table.Column<string>(nullable: true),
                    supplireEmail = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    imagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.MusicId);
                });

            migrationBuilder.CreateTable(
                name: "Photographer",
                columns: table => new
                {
                    PhotographerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplireEmail = table.Column<string>(nullable: true),
                    imagePath = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographer", x => x.PhotographerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Catering");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Music");

            migrationBuilder.DropTable(
                name: "Photographer");
        }
    }
}
