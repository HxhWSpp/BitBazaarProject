using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppsApi.Migrations
{
    public partial class imageDeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Apps_AppId",
                table: "Images");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Apps_AppId",
                table: "Images",
                column: "AppId",
                principalTable: "Apps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Apps_AppId",
                table: "Images");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Apps_AppId",
                table: "Images",
                column: "AppId",
                principalTable: "Apps",
                principalColumn: "Id");
        }
    }
}
