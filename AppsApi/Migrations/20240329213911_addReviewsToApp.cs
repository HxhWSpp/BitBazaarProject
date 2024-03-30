using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppsApi.Migrations
{
    public partial class addReviewsToApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recommended = table.Column<bool>(type: "bit", nullable: false),
                    AppId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Apps_AppId",
                        column: x => x.AppId,
                        principalTable: "Apps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.CreateIndex(
                name: "IX_Review_AppId",
                table: "Review",
                column: "AppId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3313));
        }
    }
}
