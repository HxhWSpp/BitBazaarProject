using AppsApi.Data.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace AppsApi.Data
{
    public static class DataSeeder
    {
        

        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedGenres(modelBuilder);
            SeedDevelopers(modelBuilder);
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

    }
}
