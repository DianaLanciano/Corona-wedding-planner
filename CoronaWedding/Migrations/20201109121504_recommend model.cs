using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaWedding.Migrations
{
    public partial class recommendmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhotographerId",
                table: "Account",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MusicId",
                table: "Account",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Account",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CateringId",
                table: "Account",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CateringId",
                table: "Account",
                column: "CateringId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_LocationId",
                table: "Account",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_MusicId",
                table: "Account",
                column: "MusicId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_PhotographerId",
                table: "Account",
                column: "PhotographerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Catering_CateringId",
                table: "Account",
                column: "CateringId",
                principalTable: "Catering",
                principalColumn: "CateringId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Location_LocationId",
                table: "Account",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Music_MusicId",
                table: "Account",
                column: "MusicId",
                principalTable: "Music",
                principalColumn: "MusicId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Photographer_PhotographerId",
                table: "Account",
                column: "PhotographerId",
                principalTable: "Photographer",
                principalColumn: "PhotographerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Catering_CateringId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Location_LocationId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Music_MusicId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Photographer_PhotographerId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_CateringId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_LocationId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_MusicId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_PhotographerId",
                table: "Account");

            migrationBuilder.AlterColumn<int>(
                name: "PhotographerId",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MusicId",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CateringId",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
