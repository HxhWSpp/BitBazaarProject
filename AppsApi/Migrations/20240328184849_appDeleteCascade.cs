using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppsApi.Migrations
{
    public partial class appDeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apps_Developers_DeveloperId",
                table: "Apps");

            migrationBuilder.AddForeignKey(
                name: "FK_Apps_Developers_DeveloperId",
                table: "Apps",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apps_Developers_DeveloperId",
                table: "Apps");

            migrationBuilder.AddForeignKey(
                name: "FK_Apps_Developers_DeveloperId",
                table: "Apps",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id");
        }
    }
}
