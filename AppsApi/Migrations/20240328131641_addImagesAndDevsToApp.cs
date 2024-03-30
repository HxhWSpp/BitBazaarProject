using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppsApi.Migrations
{
    public partial class addImagesAndDevsToApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "Apps",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleCardPath",
                table: "Apps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Apps_AppId",
                        column: x => x.AppId,
                        principalTable: "Apps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apps_DeveloperId",
                table: "Apps",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_AppId",
                table: "Images",
                column: "AppId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apps_Developers_DeveloperId",
                table: "Apps",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apps_Developers_DeveloperId",
                table: "Apps");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Apps_DeveloperId",
                table: "Apps");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Apps");

            migrationBuilder.DropColumn(
                name: "TitleCardPath",
                table: "Apps");
        }
    }
}
