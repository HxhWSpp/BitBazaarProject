using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppsApi.Migrations
{
    public partial class addUserLibraryAndWishlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.CreateTable(
                name: "UserLibrary",
                columns: table => new
                {
                    AppsLibraryId = table.Column<int>(type: "int", nullable: false),
                    UsersLibraryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLibrary", x => new { x.AppsLibraryId, x.UsersLibraryId });
                    table.ForeignKey(
                        name: "FK_UserLibrary_Apps_AppsLibraryId",
                        column: x => x.AppsLibraryId,
                        principalTable: "Apps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLibrary_AspNetUsers_UsersLibraryId",
                        column: x => x.UsersLibraryId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWishlist",
                columns: table => new
                {
                    AppsWishlistId = table.Column<int>(type: "int", nullable: false),
                    UsersWishlistId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWishlist", x => new { x.AppsWishlistId, x.UsersWishlistId });
                    table.ForeignKey(
                        name: "FK_UserWishlist_Apps_AppsWishlistId",
                        column: x => x.AppsWishlistId,
                        principalTable: "Apps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWishlist_AspNetUsers_UsersWishlistId",
                        column: x => x.UsersWishlistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 18, 19, 19, 719, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.CreateIndex(
                name: "IX_UserLibrary_UsersLibraryId",
                table: "UserLibrary",
                column: "UsersLibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWishlist_UsersWishlistId",
                table: "UserWishlist",
                column: "UsersWishlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "UserLibrary");

            migrationBuilder.DropTable(
                name: "UserWishlist");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 16, 36, 52, 877, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
