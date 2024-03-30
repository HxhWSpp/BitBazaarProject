using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppsApi.Migrations
{
    public partial class addDevAndGenreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "ProfilePath" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3427), "Known for their challenging and immersive worlds.", "FroSoft", "https://localhost:7110/ImageProfiles/917f8e83-9fe1-430b-8e9e-0f84162389ea.png" },
                    { 2, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3431), "Renowned for their vast open-world RPGs filled with rich lore.", "BethSoft", "https://localhost:7110/ImageProfiles/39e18c53-4ec7-430f-909b-acad430a1ad8.jpg" },
                    { 3, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3432), "Masters of narrative-driven gameplay and memorable characters.", "BioWorks", "https://localhost:7110/ImageProfiles/2483acae-a970-43b0-b84b-1ae73b80c2e8.jpg" },
                    { 4, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3433), "Creators of visually stunning and inventive platformers.", "Insomnia Games", "https://localhost:7110/ImageProfiles/6cd64236-ead2-4305-b984-5f9f2921e712.jpg" },
                    { 5, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3434), "Experts in creating addictive loot-based shooter experiences.", "Gearworks", "https://localhost:7110/ImageProfiles/2e692f68-c87d-4586-8264-ec09216b907a.jpg" },
                    { 6, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3436), "Pioneers in online multiplayer gaming and epic sci-fi universes.", "Bungo", "https://localhost:7110/ImageProfiles/ec7510ef-0e9a-4004-9bb7-9bf8ce37c816.jpg" },
                    { 7, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3437), "Crafters of cinematic action-adventure games with depth.", "Sucker Punch Studios", "https://localhost:7110/ImageProfiles/25ad4dfc-9508-461f-a58e-468c220f401a.jpg" },
                    { 8, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3438), "Innovators in fast-paced action gameplay and stylish visuals.", "Platinum Studios", "https://localhost:7110/ImageProfiles/e1891256-535f-4662-b60a-5b037303464c.jpg" },
                    { 9, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3439), "Visionaries known for pushing the boundaries of storytelling in games.", "Ko Productions", "https://localhost:7110/ImageProfiles/d7f74d91-bbd4-4321-8078-b1092ad2d510.jpg" },
                    { 10, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3441), "Masters of crafting immersive sandbox experiences for all ages.", "Playcraft", "https://localhost:7110/ImageProfiles/c4a0e99f-61dd-4d40-a5e9-12ed6de7f570.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3288), "Action" },
                    { 2, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3298), "Adventure" },
                    { 3, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3300), "Role-Playing Game (RPG)" },
                    { 4, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3301), "Strategy" },
                    { 5, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3302), "Simulation" },
                    { 6, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3304), "Puzzle" },
                    { 7, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3305), "Platformer" },
                    { 8, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3306), "Racing" },
                    { 9, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3307), "Fighting" },
                    { 10, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3309), "Sports" },
                    { 11, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3310), "Sandbox" },
                    { 12, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3310), "Stealth" },
                    { 13, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3311), "Survival" },
                    { 14, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3312), "Horror" },
                    { 15, new DateTime(2024, 3, 29, 22, 59, 6, 780, DateTimeKind.Local).AddTicks(3313), "Visual Novel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
