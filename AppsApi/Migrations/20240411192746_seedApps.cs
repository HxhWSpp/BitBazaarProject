using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppsApi.Migrations
{
    public partial class seedApps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Apps",
                columns: new[] { "Id", "CreatedAt", "Description", "DeveloperId", "Price", "ReleaseDate", "Title", "TitleCardPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4276), "PlayerUnknown's Battlegrounds (PUBG) is a battle royale shooter that pits 100 players against each other in a struggle for survival. Gather supplies and outwit your opponents to be the last person standing.", 4, 57.899999999999999, new DateTime(2013, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "PlayerUnknown's Battlegrounds (PUBG)", "https://localhost:7110/TitleCards/0.jpg" },
                    { 2, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4360), "Counter-Strike: Global Offensive (CS:GO) is a multiplayer first-person shooter game where teams of terrorists and counter-terrorists battle it out in various game modes such as Bomb Defusal and Hostage Rescue.", 1, 82.900000000000006, new DateTime(2011, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Counter-Strike: Global Offensive (CS:GO)", "https://localhost:7110/TitleCards/1.jpg" },
                    { 3, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4372), "Dota 2 is a multiplayer online battle arena (MOBA) game where two teams of five players each compete to destroy each other's Ancient, a heavily guarded structure at the opposing corner of the map.", 5, 21.899999999999999, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dota 2", "https://localhost:7110/TitleCards/2.jpg" },
                    { 4, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4385), "Grand Theft Auto V is an action-adventure game set in the fictional state of San Andreas. Players complete missions—linear scenarios with set objectives—to progress through the story.", 9, 19.899999999999999, new DateTime(2007, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto V", "https://localhost:7110/TitleCards/3.jpg" },
                    { 5, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4400), "Tom Clancy's Rainbow Six Siege is a tactical shooter game where players take on the roles of members of the Rainbow team, a counter-terrorism unit. Teamwork and strategy are key to success.", 1, 54.899999999999999, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Clancy's Rainbow Six Siege", "https://localhost:7110/TitleCards/4.jpg" },
                    { 6, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4415), "Team Fortress 2 is a multiplayer first-person shooter game with cartoony graphics and a variety of character classes. Players can engage in various game modes such as Capture the Flag and King of the Hill.", 6, 15.9, new DateTime(2006, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Team Fortress 2", "https://localhost:7110/TitleCards/5.jpg" },
                    { 7, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4428), "Terraria is an action-adventure sandbox game with an emphasis on exploration and crafting. Players can dig, build, fight, and explore in a procedurally generated 2D world.", 1, 55.899999999999999, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terraria", "https://localhost:7110/TitleCards/6.jpg" },
                    { 8, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4441), "The Witcher 3: Wild Hunt is an action role-playing game set in an open world environment. Players control Geralt of Rivia, a monster hunter known as a Witcher.", 2, 17.899999999999999, new DateTime(2014, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", "https://localhost:7110/TitleCards/7.jpg" },
                    { 9, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4562), "Rocket League is a vehicular soccer video game where players control rocket-powered cars and use them to hit a ball into their opponent's goal to score points.", 4, 96.900000000000006, new DateTime(1998, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocket League", "https://localhost:7110/TitleCards/8.jpg" },
                    { 10, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4592), "Cyberpunk 2077 is an action role-playing video game set in a dystopian Night City, an open world with six distinct regions. Players assume the first-person perspective of a customizable mercenary known as V.", 7, 33.899999999999999, new DateTime(1995, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://localhost:7110/TitleCards/9.jpg" },
                    { 11, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4606), "Among Us is an online multiplayer social deduction game where players work together to complete tasks on a spaceship, but beware, there are impostors among the crew.", 8, 90.900000000000006, new DateTime(2007, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Among Us", "https://localhost:7110/TitleCards/10.jpg" },
                    { 12, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4618), "Red Dead Redemption 2 is an action-adventure game set in an open world environment. Players control Arthur Morgan, a member of the Van der Linde gang, as he navigates the challenges of the American frontier.", 5, 71.900000000000006, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", "https://localhost:7110/TitleCards/11.jpg" },
                    { 13, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4630), "Fall Guys: Ultimate Knockout is a multiplayer party game where players compete in a series of challenges inspired by game shows. The goal is to be the last one standing.", 2, 91.900000000000006, new DateTime(1995, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fall Guys: Ultimate Knockout", "https://localhost:7110/TitleCards/12.jpg" },
                    { 14, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4643), "Rust is a multiplayer survival game where players must scavenge for resources, build shelters, and defend themselves against hostile players and NPCs.", 1, 52.899999999999999, new DateTime(2004, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", "https://localhost:7110/TitleCards/13.jpg" },
                    { 15, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4657), "Apex Legends is a free-to-play battle royale game set in the Titanfall universe. Players select from a roster of characters, each with their own unique abilities, and compete to be the last squad standing.", 7, 82.900000000000006, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apex Legends", "https://localhost:7110/TitleCards/14.jpg" },
                    { 16, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4670), "Destiny 2 is a multiplayer first-person shooter game with elements of role-playing and MMO gameplay. Players assume the role of Guardians, protectors of humanity, and battle against alien threats.", 9, 91.900000000000006, new DateTime(2017, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destiny 2", "https://localhost:7110/TitleCards/15.jpg" },
                    { 17, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4688), "Monster Hunter: World is an action role-playing game where players hunt down and defeat various monsters in a richly detailed ecosystem. Players can craft weapons and armor from materials gathered from their hunts.", 6, 12.9, new DateTime(1998, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", "https://localhost:7110/TitleCards/16.jpg" },
                    { 18, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4795), "Garry's Mod is a sandbox physics game that allows players to manipulate objects and experiment with physics in a virtual environment. It features a wide range of user-generated content and game modes.", 7, 67.900000000000006, new DateTime(2018, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garry's Mod", "https://localhost:7110/TitleCards/17.jpg" },
                    { 19, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4821), "ARK: Survival Evolved is a multiplayer survival game set in a world populated by dinosaurs and other prehistoric creatures. Players must hunt, gather, build shelters, and tame dinosaurs to survive.", 5, 64.900000000000006, new DateTime(1999, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARK: Survival Evolved", "https://localhost:7110/TitleCards/18.jpg" },
                    { 20, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4837), "PAYDAY 2 is a cooperative first-person shooter game where players take on the roles of masked criminals performing various heists and robberies. Team coordination and planning are essential for success.", 1, 91.900000000000006, new DateTime(2009, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAYDAY 2", "https://localhost:7110/TitleCards/19.jpg" },
                    { 21, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4852), "No Man's Sky is a procedurally generated open-world exploration game set in a vast universe. Players explore planets, gather resources, trade with alien civilizations, and uncover the mysteries of the cosmos.", 6, 88.900000000000006, new DateTime(2018, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Man's Sky", "https://localhost:7110/TitleCards/20.jpg" },
                    { 22, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4867), "Warframe is a cooperative third-person shooter game where players control members of the Tenno, ancient warriors who have awoken from centuries of cryosleep to battle against various factions in a war-torn solar system.", 5, 41.899999999999999, new DateTime(2002, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warframe", "https://localhost:7110/TitleCards/21.jpg" },
                    { 23, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4884), "Borderlands 3 is a first-person shooter looter game set in a cel-shaded open world. Players control one of four Vault Hunters, each with their own unique abilities and playstyles, as they journey across the galaxy in search of treasure and glory.", 9, 74.900000000000006, new DateTime(2002, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borderlands 3", "https://localhost:7110/TitleCards/22.jpg" },
                    { 24, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4902), "Sekiro: Shadows Die Twice is an action-adventure game set in a fictionalized late 1500s Sengoku period Japan. Players control a shinobi known as Wolf as he embarks on a quest to rescue his kidnapped lord and seek revenge on his enemies.", 9, 83.900000000000006, new DateTime(2016, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", "https://localhost:7110/TitleCards/23.jpg" },
                    { 25, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4918), "Valheim is a survival and sandbox game set in a procedurally generated world inspired by Norse mythology. Players must gather resources, craft tools and weapons, build structures, and defeat enemies in order to survive and thrive in the world of Valheim.", 6, 61.899999999999999, new DateTime(2006, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valheim", "https://localhost:7110/TitleCards/24.jpg" },
                    { 26, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4933), "Football Manager 2021 is a football management simulation game where players take on the role of a football manager, controlling various aspects of their chosen club, including tactics, transfers, and team selection.", 4, 25.899999999999999, new DateTime(1996, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Manager 2021", "https://localhost:7110/TitleCards/25.jpg" },
                    { 27, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(5061), "Subnautica is an underwater survival game set on an alien planet. Players must explore the ocean depths, gather resources, and build habitats while avoiding dangerous creatures and uncovering the mysteries of the planet.", 4, 2.8999999999999999, new DateTime(1998, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subnautica", "https://localhost:7110/TitleCards/26.jpg" },
                    { 28, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(5085), "Left 4 Dead 2 is a cooperative first-person shooter game where players take on the roles of survivors of a zombie apocalypse. Teamwork and coordination are essential as players fight their way through hordes of infected while completing objectives.", 8, 19.899999999999999, new DateTime(2009, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Left 4 Dead 2", "https://localhost:7110/TitleCards/27.jpg" },
                    { 29, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(5102), "The Elder Scrolls V: Skyrim is an action role-playing game set in the fantasy world of Tamriel. Players assume the role of the Dragonborn, a prophesied hero destined to save the world from destruction.", 9, 65.900000000000006, new DateTime(2006, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", "https://localhost:7110/TitleCards/28.jpg" },
                    { 30, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(5119), "Halo: The Master Chief Collection is a compilation of first-person shooter games from the Halo series. Players can experience the epic story of Master Chief across multiple games and campaigns.", 9, 65.900000000000006, new DateTime(2017, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo: The Master Chief Collection", "https://localhost:7110/TitleCards/29.jpg" },
                    { 31, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(5138), "Minecraft is a sandbox game that allows players to build and explore virtual worlds made up of blocks. Players can gather resources, craft tools and items, and create structures and landscapes.", 1, 5.9000000000000004, new DateTime(2005, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://localhost:7110/TitleCards/30.jpg" },
                    { 32, new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(5157), "Control is an action-adventure game set in a mysterious government building called the Federal Bureau of Control. Players control Jesse Faden, who possesses supernatural abilities, as she investigates paranormal phenomena and fights otherworldly enemies.", 6, 85.900000000000006, new DateTime(2011, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", "https://localhost:7110/TitleCards/31.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 22, 27, 46, 446, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.InsertData(
                table: "AppGenre",
                columns: new[] { "AppsId", "GenresId" },
                values: new object[,]
                {
                    { 1, 11 },
                    { 1, 12 },
                    { 2, 1 },
                    { 3, 2 },
                    { 3, 6 },
                    { 4, 2 },
                    { 5, 8 },
                    { 5, 14 },
                    { 6, 6 },
                    { 6, 12 },
                    { 7, 5 },
                    { 7, 13 },
                    { 8, 4 },
                    { 8, 5 },
                    { 9, 1 },
                    { 9, 8 },
                    { 10, 3 },
                    { 10, 10 },
                    { 11, 6 },
                    { 12, 12 },
                    { 13, 8 },
                    { 14, 8 },
                    { 14, 11 },
                    { 15, 13 },
                    { 16, 8 },
                    { 16, 9 },
                    { 16, 14 },
                    { 17, 4 },
                    { 17, 8 },
                    { 17, 11 },
                    { 18, 5 },
                    { 18, 9 },
                    { 19, 5 },
                    { 19, 11 },
                    { 20, 1 },
                    { 20, 7 },
                    { 21, 1 },
                    { 21, 2 },
                    { 22, 6 },
                    { 22, 8 },
                    { 23, 5 },
                    { 23, 6 }
                });

            migrationBuilder.InsertData(
                table: "AppGenre",
                columns: new[] { "AppsId", "GenresId" },
                values: new object[,]
                {
                    { 23, 13 },
                    { 24, 2 },
                    { 24, 4 },
                    { 25, 3 },
                    { 26, 6 },
                    { 26, 8 },
                    { 26, 9 },
                    { 27, 12 },
                    { 27, 14 },
                    { 28, 9 },
                    { 28, 14 },
                    { 29, 6 },
                    { 29, 12 },
                    { 30, 1 },
                    { 30, 3 },
                    { 31, 4 },
                    { 31, 8 },
                    { 31, 12 },
                    { 32, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 26, 9 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 27, 12 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 27, 14 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 28, 14 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 29, 6 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 29, 12 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 31, 4 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 31, 8 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 31, 12 });

            migrationBuilder.DeleteData(
                table: "AppGenre",
                keyColumns: new[] { "AppsId", "GenresId" },
                keyValues: new object[] { 32, 14 });

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 111, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 19, 59, 110, DateTimeKind.Local).AddTicks(9973));
        }
    }
}
