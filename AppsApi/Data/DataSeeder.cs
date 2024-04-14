using AppsApi.Data.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;

namespace AppsApi.Data
{
    public static class DataSeeder
    {
        


        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedGenres(modelBuilder);
            SeedDevelopers(modelBuilder);
            SeedApps(modelBuilder);
        }

        private static void  SeedGenres(this ModelBuilder modelBuilder)
        {           
            List<Genre> genres = new List<string>()
            {
            "Action",
            "Adventure",
            "Role-Playing Game (RPG)",
            "Strategy",
            "Simulation",
            "Puzzle",
            "Platformer",
            "Racing",
            "Fighting",
            "Sports",
            "Sandbox",
            "Stealth",
            "Survival",
            "Horror",
            "Visual Novel"
            }.Select((item , index) => new Genre()
            {
                Id = index + 1,
                Name = item,
                CreatedAt = DateTime.Now
            }).ToList();
            modelBuilder.Entity<Genre>().HasData(genres);
        }

        private static void SeedDevelopers(this ModelBuilder modelBuilder)
        {
            List<string> devName = new List<string>()
            {
            "FroSoft",
            "BethSoft",
            "BioWorks",
            "Insomnia Games",
            "Gearworks",
            "Bungo",
            "Sucker Punch Studios",
            "Platinum Studios",
            "Ko Productions",
            "Playcraft"           
            };
            List<string> devDesc = new List<string>()
            {
            "Known for their challenging and immersive worlds.",
            "Renowned for their vast open-world RPGs filled with rich lore.",
            "Masters of narrative-driven gameplay and memorable characters.",
            "Creators of visually stunning and inventive platformers.",
            "Experts in creating addictive loot-based shooter experiences.",
            "Pioneers in online multiplayer gaming and epic sci-fi universes.",
            "Crafters of cinematic action-adventure games with depth.",
            "Innovators in fast-paced action gameplay and stylish visuals.",
            "Visionaries known for pushing the boundaries of storytelling in games.",
            "Masters of crafting immersive sandbox experiences for all ages."
            };
            List<string> profilePath = new List<string>()
            {
              "https://localhost:7110/ImageProfiles/917f8e83-9fe1-430b-8e9e-0f84162389ea.png",
              "https://localhost:7110/ImageProfiles/39e18c53-4ec7-430f-909b-acad430a1ad8.jpg",
              "https://localhost:7110/ImageProfiles/2483acae-a970-43b0-b84b-1ae73b80c2e8.jpg",
              "https://localhost:7110/ImageProfiles/6cd64236-ead2-4305-b984-5f9f2921e712.jpg",
              "https://localhost:7110/ImageProfiles/2e692f68-c87d-4586-8264-ec09216b907a.jpg",
              "https://localhost:7110/ImageProfiles/ec7510ef-0e9a-4004-9bb7-9bf8ce37c816.jpg",
              "https://localhost:7110/ImageProfiles/25ad4dfc-9508-461f-a58e-468c220f401a.jpg",
              "https://localhost:7110/ImageProfiles/e1891256-535f-4662-b60a-5b037303464c.jpg",
              "https://localhost:7110/ImageProfiles/d7f74d91-bbd4-4321-8078-b1092ad2d510.jpg",
              "https://localhost:7110/ImageProfiles/c4a0e99f-61dd-4d40-a5e9-12ed6de7f570.jpg"
            };

            List<Developer> devs = new List<Developer>();
            for (int i = 0; i < devName.Count(); i++)
            {
                var dev = new Developer
                {
                    Id = i+1,
                    Name = devName[i],
                    Description = devDesc[i],
                    ProfilePath = profilePath[i],
                    CreatedAt = DateTime.Now
                };
                devs.Add(dev);
            }

            modelBuilder.Entity<Developer>().HasData(devs);


        }

        private static void SeedApps(this ModelBuilder modelBuilder)
        {
            Dictionary<string, string> gameDescriptions = new Dictionary<string, string>
                {
                    {"PlayerUnknown's Battlegrounds (PUBG)", "PlayerUnknown's Battlegrounds (PUBG) is a battle royale shooter that pits 100 players against each other in a struggle for survival. Gather supplies and outwit your opponents to be the last person standing."},
                    {"Counter-Strike: Global Offensive (CS:GO)", "Counter-Strike: Global Offensive (CS:GO) is a multiplayer first-person shooter game where teams of terrorists and counter-terrorists battle it out in various game modes such as Bomb Defusal and Hostage Rescue."},
                    {"Dota 2", "Dota 2 is a multiplayer online battle arena (MOBA) game where two teams of five players each compete to destroy each other's Ancient, a heavily guarded structure at the opposing corner of the map."},
                    {"Grand Theft Auto V", "Grand Theft Auto V is an action-adventure game set in the fictional state of San Andreas. Players complete missions—linear scenarios with set objectives—to progress through the story."},
                    {"Tom Clancy's Rainbow Six Siege", "Tom Clancy's Rainbow Six Siege is a tactical shooter game where players take on the roles of members of the Rainbow team, a counter-terrorism unit. Teamwork and strategy are key to success."},
                    {"Team Fortress 2", "Team Fortress 2 is a multiplayer first-person shooter game with cartoony graphics and a variety of character classes. Players can engage in various game modes such as Capture the Flag and King of the Hill."},
                    {"Terraria", "Terraria is an action-adventure sandbox game with an emphasis on exploration and crafting. Players can dig, build, fight, and explore in a procedurally generated 2D world."},
                    {"The Witcher 3: Wild Hunt", "The Witcher 3: Wild Hunt is an action role-playing game set in an open world environment. Players control Geralt of Rivia, a monster hunter known as a Witcher."},
                    {"Rocket League", "Rocket League is a vehicular soccer video game where players control rocket-powered cars and use them to hit a ball into their opponent's goal to score points."},
                    {"Cyberpunk 2077", "Cyberpunk 2077 is an action role-playing video game set in a dystopian Night City, an open world with six distinct regions. Players assume the first-person perspective of a customizable mercenary known as V."},
                    {"Among Us", "Among Us is an online multiplayer social deduction game where players work together to complete tasks on a spaceship, but beware, there are impostors among the crew."},
                    {"Red Dead Redemption 2", "Red Dead Redemption 2 is an action-adventure game set in an open world environment. Players control Arthur Morgan, a member of the Van der Linde gang, as he navigates the challenges of the American frontier."},
                    {"Fall Guys: Ultimate Knockout", "Fall Guys: Ultimate Knockout is a multiplayer party game where players compete in a series of challenges inspired by game shows. The goal is to be the last one standing."},
                    {"Rust", "Rust is a multiplayer survival game where players must scavenge for resources, build shelters, and defend themselves against hostile players and NPCs."},
                    {"Apex Legends", "Apex Legends is a free-to-play battle royale game set in the Titanfall universe. Players select from a roster of characters, each with their own unique abilities, and compete to be the last squad standing."},
                    {"Destiny 2", "Destiny 2 is a multiplayer first-person shooter game with elements of role-playing and MMO gameplay. Players assume the role of Guardians, protectors of humanity, and battle against alien threats."},
                    {"Monster Hunter: World", "Monster Hunter: World is an action role-playing game where players hunt down and defeat various monsters in a richly detailed ecosystem. Players can craft weapons and armor from materials gathered from their hunts."},
                    {"Garry's Mod", "Garry's Mod is a sandbox physics game that allows players to manipulate objects and experiment with physics in a virtual environment. It features a wide range of user-generated content and game modes."},
                    {"ARK: Survival Evolved", "ARK: Survival Evolved is a multiplayer survival game set in a world populated by dinosaurs and other prehistoric creatures. Players must hunt, gather, build shelters, and tame dinosaurs to survive."},
                   
                    {"PAYDAY 2", "PAYDAY 2 is a cooperative first-person shooter game where players take on the roles of masked criminals performing various heists and robberies. Team coordination and planning are essential for success."},
                    {"No Man's Sky", "No Man's Sky is a procedurally generated open-world exploration game set in a vast universe. Players explore planets, gather resources, trade with alien civilizations, and uncover the mysteries of the cosmos."},
                    {"Warframe", "Warframe is a cooperative third-person shooter game where players control members of the Tenno, ancient warriors who have awoken from centuries of cryosleep to battle against various factions in a war-torn solar system."},
                    {"Borderlands 3", "Borderlands 3 is a first-person shooter looter game set in a cel-shaded open world. Players control one of four Vault Hunters, each with their own unique abilities and playstyles, as they journey across the galaxy in search of treasure and glory."},
                    {"Sekiro: Shadows Die Twice", "Sekiro: Shadows Die Twice is an action-adventure game set in a fictionalized late 1500s Sengoku period Japan. Players control a shinobi known as Wolf as he embarks on a quest to rescue his kidnapped lord and seek revenge on his enemies."},
                    {"Valheim", "Valheim is a survival and sandbox game set in a procedurally generated world inspired by Norse mythology. Players must gather resources, craft tools and weapons, build structures, and defeat enemies in order to survive and thrive in the world of Valheim."},
                    {"Football Manager 2021", "Football Manager 2021 is a football management simulation game where players take on the role of a football manager, controlling various aspects of their chosen club, including tactics, transfers, and team selection."},
                    {"Subnautica", "Subnautica is an underwater survival game set on an alien planet. Players must explore the ocean depths, gather resources, and build habitats while avoiding dangerous creatures and uncovering the mysteries of the planet."},
                    {"Left 4 Dead 2", "Left 4 Dead 2 is a cooperative first-person shooter game where players take on the roles of survivors of a zombie apocalypse. Teamwork and coordination are essential as players fight their way through hordes of infected while completing objectives."},
                    {"The Elder Scrolls V: Skyrim", "The Elder Scrolls V: Skyrim is an action role-playing game set in the fantasy world of Tamriel. Players assume the role of the Dragonborn, a prophesied hero destined to save the world from destruction."},
                    {"Halo: The Master Chief Collection", "Halo: The Master Chief Collection is a compilation of first-person shooter games from the Halo series. Players can experience the epic story of Master Chief across multiple games and campaigns."},
                    {"Minecraft", "Minecraft is a sandbox game that allows players to build and explore virtual worlds made up of blocks. Players can gather resources, craft tools and items, and create structures and landscapes."},
                    {"Control", "Control is an action-adventure game set in a mysterious government building called the Federal Bureau of Control. Players control Jesse Faden, who possesses supernatural abilities, as she investigates paranormal phenomena and fights otherworldly enemies."}
                    //{"The Forest", "The Forest is a survival horror game set on a deserted island inhabited by cannibalistic mutants. Players must explore the island, gather resources, and build shelters to survive while uncovering the secrets of the island and searching for a way to escape."},
                    //{"DOOM Eternal", "DOOM Eternal is a first-person shooter game and the fifth main entry in the DOOM series. Players control the Doom Slayer as he battles demonic forces from Hell across various dimensions."},
                    //{"Stardew Valley", "Stardew Valley is a farming simulation game where players inherit a run-down farm and must restore it to its former glory. Players can grow crops, raise animals, mine for resources, and build relationships with the townsfolk."},
                    //{"Dead by Daylight", "Dead by Daylight is an asymmetric multiplayer horror game where one player takes on the role of a killer and the others play as survivors trying to escape. Teamwork and strategy are crucial for survival."},
                    //{"Final Fantasy XIV Online", "Final Fantasy XIV Online is a massively multiplayer online role-playing game set in the fictional world of Eorzea. Players create and customize their own characters and embark on epic quests and adventures."},
                    //{"Star Wars Jedi: Fallen Order", "Star Wars Jedi: Fallen Order is an action-adventure game set in the Star Wars universe. Players control Cal Kestis, a young Jedi Padawan, as he evades the Empire's Inquisitors and seeks to rebuild the Jedi Order."},
                    //{"Phasmophobia", "Phasmophobia is a multiplayer psychological horror game where players take on the role of paranormal investigators exploring haunted locations. Using various tools and equipment, players must gather evidence of paranormal activity while avoiding being hunted by ghosts."},
                    //{"Call of Duty: Black Ops Cold War", "Call of Duty: Black Ops Cold War is a first-person shooter game set during the Cold War era. Players take on the roles of various operatives and engage in covert operations and intense multiplayer battles."},
                    //{"Total War: Three Kingdoms", "Total War: Three Kingdoms is a turn-based strategy game set in ancient China during the Three Kingdoms period. Players can engage in epic battles, forge alliances, and conquer territories as they strive to unite the land under their rule."},
                    //{"Persona 5 Strikers", "Persona 5 Strikers is an action role-playing game and a sequel to Persona 5. Players control the Phantom Thieves as they travel across Japan, fighting shadows and uncovering a conspiracy."},
                    //{"Mount & Blade II: Bannerlord", "Mount & Blade II: Bannerlord is an action role-playing game and a prequel to Mount & Blade. Players can engage in medieval warfare, build armies, conquer territories, and participate in dynamic battles."},
                    //{"Elite Dangerous", "Elite Dangerous is a space simulation game set in a 1:1 scale open-world galaxy based on the Milky Way. Players can explore, trade, fight, and engage in various activities in a vast and realistic universe."},
                    //{"Euro Truck Simulator 2", "Euro Truck Simulator 2 is a truck simulation game where players drive and manage their own trucking business across Europe. Players can transport goods, build their fleet, and expand their operations as they progress."},
                    //{"Terraria: Otherworlds", "Terraria: Otherworlds is an upcoming action-adventure sandbox game and a spin-off of Terraria. Players must defend against an otherworldly invasion by building defenses, crafting weapons, and exploring new biomes."},
                    //{"Monster Hunter Rise", "Monster Hunter Rise is an action role-playing game where players hunt down and defeat various monsters in a lush and vibrant ecosystem. Players can wield powerful weapons and team up with friends in cooperative multiplayer hunts."},
                    //{"The Binding of Isaac: Rebirth", "The Binding of Isaac: Rebirth is a roguelike action-adventure game where players control Isaac, a young boy who must navigate through procedurally generated dungeons filled with monsters, traps, and treasure."},
                    //{"NBA 2K21", "NBA 2K21 is a basketball simulation game where players can experience the excitement and intensity of professional basketball. Players can create their own player, build their career, and compete in various game modes."},
                    //{"Hades", "Hades is an action role-playing game and a rogue-like dungeon crawler where players control Zagreus, the son of Hades, as he attempts to escape the underworld. Each escape attempt is unique, with different challenges and rewards."},
                    //{"Sea of Thieves", "Sea of Thieves is a multiplayer pirate adventure game where players explore the open seas, search for treasure, and engage in naval battles with other players. Teamwork and cooperation are essential for success."},
                    //{"Divinity: Original Sin 2", "Divinity: Original Sin 2 is a role-playing game set in a fantasy world where players control a party of characters with unique abilities and skills. Players can engage in turn-based combat, solve puzzles, and explore a richly detailed world."},
                    //{"Assassin's Creed Valhalla", "Assassin's Creed Valhalla is an action role-playing game set in the Viking age. Players control Eivor, a Viking raider, as they lead their clan to conquer the lands of England."},
                    //{"Crusader Kings III", "Crusader Kings III is a grand strategy game set in the medieval world. Players control a dynasty and must navigate the complex politics and intrigue of the time to expand their influence and secure their legacy."},
                    //{"XCOM 2", "XCOM 2 is a turn-based tactics game where players control a squad of soldiers tasked with defending Earth from alien invaders. Players must deploy their troops strategically and make tough decisions to ensure humanity's survival."},
                    //{"Factorio", "Factorio is a construction and management simulation game where players build and manage automated factories to produce goods and fend off hostile alien creatures. Players must optimize their production chains and defend their factories from attacks."},
                    //{"Half-Life: Alyx", "Half-Life: Alyx is a virtual reality first-person shooter game set in the Half-Life universe. Players control Alyx Vance as she battles against the alien Combine and unravels the mysteries of the series."},
                    //{"Risk of Rain 2", "Risk of Rain 2 is a third-person roguelike shooter game where players must survive on an alien planet filled with hostile creatures. Players must explore, fight, and scavenge for resources as they attempt to escape the planet."},
                    //{"Outward", "Outward is an open-world role-playing game where players take on the role of an adventurer in a harsh and unforgiving fantasy world. Players must survive the elements, battle enemies, and explore mysterious dungeons."},
                    //{"Dyson Sphere Program", "Dyson Sphere Program is a space simulation game where players build and manage a network of interstellar factories to harness the energy of a dying star. Players must explore, research, and automate production to build a Dyson sphere."},
                    //{"Resident Evil Village", "Resident Evil Village is a survival horror game and the eighth main installment in the Resident Evil series. Players control Ethan Winters as he searches for his kidnapped daughter in a mysterious village filled with terrifying creatures."},
                    //{"Cities: Skylines", "Cities: Skylines is a city-building simulation game where players design, build, and manage their own city. Players must balance the needs of their citizens, manage resources, and deal with various challenges to create a thriving metropolis."},
                    //{"Planet Zoo", "Planet Zoo is a zoo simulation game where players design, build, and manage their own zoo. Players must create habitats, care for animals, and satisfy the needs of visitors while maintaining the welfare and conservation of their animal inhabitants."},
                    //{"Satisfactory", "Satisfactory is a first-person factory building game where players explore an alien planet, gather resources, and build massive automated factories. Players must optimize their production chains to meet the demands of a growing industrial empire."},
                    //{"Persona 4 Golden", "Persona 4 Golden is a role-playing game and an enhanced version of Persona 4. Players control a high school student who discovers the ability to enter a mysterious TV world where they must solve murders and confront their inner demons."},
                    //{"Yakuza: Like a Dragon", "Yakuza: Like a Dragon is an action role-playing game and the eighth main installment in the Yakuza series. Players control Ichiban Kasuga, a low-ranking yakuza who embarks on a quest for redemption and revenge."},
                    //{"Cities: Skylines - Green Cities", "Cities: Skylines - Green Cities is an expansion pack for Cities: Skylines that introduces new environmentally friendly buildings, policies, and services to help players create sustainable and eco-friendly cities."},
                    //{"Grounded", "Grounded is a survival game set in a backyard where players have been shrunk to the size of insects. Players must gather resources, build shelters, and fend off hostile insects as they explore, craft, and survive in a dangerous world."},
                    //{"Forza Horizon 4", "Forza Horizon 4 is a racing game set in an open-world recreation of Great Britain. Players can participate in various racing events, explore the open world, and customize their cars with a wide range of options."},
                    //{"Horizon Zero Dawn", "Horizon Zero Dawn is an action role-playing game set in a post-apocalyptic world where robotic creatures roam the land. Players control Aloy, a hunter and archer, as she explores the world, uncovers its secrets, and battles against the machines."},
                    //{"Detroit: Become Human", "Detroit: Become Human is an interactive drama game set in a futuristic Detroit where androids have become sentient and demand equal rights. Players control multiple characters as they navigate through a branching narrative with multiple endings."},
                    //{"Farming Simulator 19", "Farming Simulator 19 is a farming simulation game where players manage and operate their own farm. Players can cultivate crops, raise livestock, and expand their farm with a variety of vehicles, equipment, and buildings."},
                    //{"Disco Elysium", "Disco Elysium is a role-playing game where players control a detective with amnesia investigating a murder case in a fictional city. Players must navigate through dialogue trees and make choices that affect the outcome of the story."},
                    //{"Metro Exodus", "Metro Exodus is a first-person shooter game set in a post-apocalyptic Russia. Players control Artyom, a survivor of a nuclear war, as he travels across the country in search of a new home for his people."},
                    //{"RimWorld", "RimWorld is a colony simulation game where players manage a group of colonists stranded on a distant planet. Players must build and expand their colony, manage resources, and survive the various challenges of the harsh environment."},
                    //{"Fallout 4", "Fallout 4 is an action role-playing game set in a post-apocalyptic open world. Players control the Sole Survivor, who emerges from a cryogenic stasis in a world devastated by nuclear war."},
                    //{"Ghostrunner", "Ghostrunner is a first-person cyberpunk action game set in a dystopian future. Players control a cybernetic ninja as they navigate through vertical environments, slice through enemies with a katana, and uncover the secrets of their world."},
                    //{"Subnautica: Below Zero", "Subnautica: Below Zero is a standalone expansion to Subnautica set in the arctic region of the same alien planet. Players must survive in the icy waters, explore new biomes, and uncover the mysteries hidden beneath the frozen surface."},
                    //{"Jurassic World Evolution 2", "Jurassic World Evolution 2 is a simulation game where players build and manage their own Jurassic Park. Players must create habitats for dinosaurs, manage resources, and deal with emergencies and disasters."},
                    //{"Microsoft Flight Simulator", "Microsoft Flight Simulator is a flight simulation game where players can pilot a variety of aircraft and explore the world. The game features realistic weather, day-night cycles, and detailed recreations of real-world locations."},
                    //{"Call of Duty: Warzone", "Call of Duty: Warzone is a free-to-play battle royale game set in the Call of Duty universe. Players compete in a last-man-standing battle royale mode where they must scavenge for weapons, equipment, and resources while avoiding a deadly gas."},
                    //{"Star Wars Battlefront II", "Star Wars Battlefront II is a multiplayer first-person shooter game set in the Star Wars universe. Players can engage in large-scale battles across iconic planets and locations from the Star Wars saga."},
                    //{"Age of Empires III: Definitive Edition", "Age of Empires III: Definitive Edition is a remastered version of the classic real-time strategy game Age of Empires III. Players build and manage colonies, gather resources, and engage in battles across various historical periods."},
                    //{"American Truck Simulator", "American Truck Simulator is a truck simulation game where players drive and manage their own trucking business across the United States. Players can transport goods, build their fleet, and explore iconic American landscapes."},
                    //{"Phantasy Star Online 2", "Phantasy Star Online 2 is a free-to-play multiplayer online role-playing game set in a science fiction universe. Players create and customize their own characters and embark on quests, battles, and adventures across various planets."},
                    //{"Mass Effect Legendary Edition", "Mass Effect Legendary Edition is a remastered collection of the Mass Effect trilogy. Players control Commander Shepard as they explore the galaxy, recruit allies, and battle against a threat that could destroy all life."},
                    //{"Assassin's Creed Odyssey", "Assassin's Creed Odyssey is an action role-playing game set in ancient Greece. Players control a mercenary named Alexios or Kassandra as they embark on an epic journey to uncover their mysterious past and confront the forces threatening their homeland."},
                    //{"Black Desert Online", "Black Desert Online is a sandbox-oriented massively multiplayer online role-playing game set in a fantasy world. Players can explore vast open worlds, engage in action-packed combat, and participate in various activities such as fishing, trading, and crafting."},
                    //{"Battlefield V", "Battlefield V is a first-person shooter game set during World War II. Players can engage in large-scale battles across various theaters of war, including Europe, Africa, and the Pacific."},
                    //{"Terraria: Journey's End", "Terraria: Journey's End is the final major update to the sandbox adventure game Terraria. It introduces new content, features, and improvements, including new enemies, items, biomes, and gameplay mechanics."},
                    //{"Monster Hunter Stories 2: Wings of Ruin", "Monster Hunter Stories 2: Wings of Ruin is a role-playing game set in the Monster Hunter universe. Players take on the role of a Monster Rider and embark on a journey to uncover the secrets of the mysterious Razewing Ratha."},
                    //{"Resident Evil 3", "Resident Evil 3 is a survival horror game and a remake of the 1999 game Resident Evil 3: Nemesis. Players control Jill Valentine as she attempts to escape the zombie-infested Raccoon City while being pursued by the relentless Nemesis."},
                    //{"NieR: Automata", "NieR: Automata is an action role-playing game set in a dystopian future where humanity has been driven from Earth by invading machines. Players control combat androids 2B, 9S, and A2 as they fight against the machines and uncover the truth of their existence."},
                    //{"The Sims 4", "The Sims 4 is a life simulation game where players create and control virtual characters called Sims. Players can build homes, pursue careers, form relationships, and explore a variety of activities and hobbies."},
                    //{"Valve Index", "Valve Index is a virtual reality system developed by Valve Corporation. It includes a high-fidelity VR headset, controllers, and base stations for tracking, offering an immersive VR experience for gaming, entertainment, and more."},
                    //{"The Long Dark", "The Long Dark is a survival game set in the aftermath of a geomagnetic disaster. Players must navigate the frozen wilderness, gather resources, and survive against the elements and wildlife while uncovering the mysteries of the world."},
                    //{"Dead Space", "Dead Space is a survival horror game set aboard a mining spaceship infested with grotesque alien creatures known as Necromorphs. Players control Isaac Clarke as he battles against the horrifying creatures and fights to survive."},
                    //{"DayZ", "DayZ is a multiplayer survival game set in a post-apocalyptic world overrun by zombies. Players must scavenge for food, water, and supplies, while also dealing with other players and the ever-present threat of the infected."},
                    //{"Shadow of the Tomb Raider", "Shadow of the Tomb Raider is an action-adventure game and the third installment in the rebooted Tomb Raider series. Players control Lara Croft as she explores ancient ruins, solves puzzles, and battles against enemies in her quest to stop a Mayan apocalypse."}
                };
          

           
          


            var appList = new List<App>();
            var random = new Random();            
                DateTime start = new DateTime(1995, 1, 1);
                int range = (DateTime.Today - start).Days;
           
            for (int i = 0; i < gameDescriptions.Count(); i++)
            {
                int developerId = random.Next(1, 10);
                var app = new App
                {
                    Id = i + 1,
                    CreatedAt = DateTime.Now,
                    ReleaseDate = start.AddDays(random.Next(range)),
                    TitleCardPath = $"https://localhost:7110/TitleCards/{i}.jpg",
                    Title = $"{gameDescriptions.ElementAt(i).Key}",
                    Description = $"{gameDescriptions.ElementAt(i).Value}",
                    Price = random.Next(2, 100),                               
                };

                
                for (int j = 0; j < random.Next(1, 4); j++)
                {
                    var genreId = random.Next(1, 15); 
                    var genre  = new Genre { Id = genreId };
                    if (app.Genres.Any(a => a.Id == genreId))
                    {
                        
                    }
                    else
                    {
                        app.Genres.Add(genre);
                    }
                }

               
                appList.Add(app);

          

                
            }

           
            
            modelBuilder.Entity<App>().HasData(appList.Select(a => new
            {
                Id = a.Id,
                CreatedAt = a.CreatedAt,
                ReleaseDate = a.ReleaseDate,
                Title = a.Title,
                Description = a.Description,
                TitleCardPath = a.TitleCardPath,
                Price = a.Price,
                DeveloperId = random.Next(1, 10),
            }));


            foreach (var app in appList)
            {
                foreach (var genre in app.Genres)
                {
                    modelBuilder.Entity<App>().HasMany(a => a.Genres).WithMany(a => a.Apps).UsingEntity(e => e.HasData(new { AppsId = app.Id, GenresId = genre.Id }));
                }
                List<Image> list = new List<Image>();
                for (int i = 0; i < 3; i++)
                {
                    var image = new Image
                    {
                        Id = app.Id * 10 + i + 1,
                        CreatedAt = app.CreatedAt,
                        ImagePath = $"https://localhost:7110/ImagesForApps/{app.Id}{i + 1}.jpg",
  

                    };
                    list.Add(image);
                }
                modelBuilder.Entity<Image>().HasData(list.Select(a => new
                {
                    Id = a.Id,
                    CreatedAt = a.CreatedAt,
                    ImagePath = a.ImagePath,
                    AppId = app.Id
                   
                    
                    
                    
                   
                }));

            }
           


        }


    }
}
