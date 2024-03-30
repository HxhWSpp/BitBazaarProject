﻿// <auto-generated />
using System;
using AppsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppGenre", b =>
                {
                    b.Property<int>("AppsId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("AppsId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("AppGenre", (string)null);
                });

            modelBuilder.Entity("AppsApi.Data.Entities.App", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleCardPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("AppsApi.Data.Entities.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4502),
                            Description = "Known for their challenging and immersive worlds.",
                            Name = "FroSoft",
                            ProfilePath = "https://localhost:7110/ImageProfiles/917f8e83-9fe1-430b-8e9e-0f84162389ea.png"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4505),
                            Description = "Renowned for their vast open-world RPGs filled with rich lore.",
                            Name = "BethSoft",
                            ProfilePath = "https://localhost:7110/ImageProfiles/39e18c53-4ec7-430f-909b-acad430a1ad8.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4506),
                            Description = "Masters of narrative-driven gameplay and memorable characters.",
                            Name = "BioWorks",
                            ProfilePath = "https://localhost:7110/ImageProfiles/2483acae-a970-43b0-b84b-1ae73b80c2e8.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4507),
                            Description = "Creators of visually stunning and inventive platformers.",
                            Name = "Insomnia Games",
                            ProfilePath = "https://localhost:7110/ImageProfiles/6cd64236-ead2-4305-b984-5f9f2921e712.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4508),
                            Description = "Experts in creating addictive loot-based shooter experiences.",
                            Name = "Gearworks",
                            ProfilePath = "https://localhost:7110/ImageProfiles/2e692f68-c87d-4586-8264-ec09216b907a.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4510),
                            Description = "Pioneers in online multiplayer gaming and epic sci-fi universes.",
                            Name = "Bungo",
                            ProfilePath = "https://localhost:7110/ImageProfiles/ec7510ef-0e9a-4004-9bb7-9bf8ce37c816.jpg"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4511),
                            Description = "Crafters of cinematic action-adventure games with depth.",
                            Name = "Sucker Punch Studios",
                            ProfilePath = "https://localhost:7110/ImageProfiles/25ad4dfc-9508-461f-a58e-468c220f401a.jpg"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4512),
                            Description = "Innovators in fast-paced action gameplay and stylish visuals.",
                            Name = "Platinum Studios",
                            ProfilePath = "https://localhost:7110/ImageProfiles/e1891256-535f-4662-b60a-5b037303464c.jpg"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4513),
                            Description = "Visionaries known for pushing the boundaries of storytelling in games.",
                            Name = "Ko Productions",
                            ProfilePath = "https://localhost:7110/ImageProfiles/d7f74d91-bbd4-4321-8078-b1092ad2d510.jpg"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4515),
                            Description = "Masters of crafting immersive sandbox experiences for all ages.",
                            Name = "Playcraft",
                            ProfilePath = "https://localhost:7110/ImageProfiles/c4a0e99f-61dd-4d40-a5e9-12ed6de7f570.jpg"
                        });
                });

            modelBuilder.Entity("AppsApi.Data.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4183),
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4194),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4195),
                            Name = "Role-Playing Game (RPG)"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4196),
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4197),
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4355),
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4357),
                            Name = "Platformer"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4358),
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4359),
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4363),
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4363),
                            Name = "Sandbox"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4364),
                            Name = "Stealth"
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4365),
                            Name = "Survival"
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4366),
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2024, 3, 29, 23, 39, 11, 44, DateTimeKind.Local).AddTicks(4367),
                            Name = "Visual Novel"
                        });
                });

            modelBuilder.Entity("AppsApi.Data.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AppId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("AppsApi.Data.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AppId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Recommended")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("AppGenre", b =>
                {
                    b.HasOne("AppsApi.Data.Entities.App", null)
                        .WithMany()
                        .HasForeignKey("AppsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppsApi.Data.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppsApi.Data.Entities.App", b =>
                {
                    b.HasOne("AppsApi.Data.Entities.Developer", "Developer")
                        .WithMany("Apps")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Developer");
                });

            modelBuilder.Entity("AppsApi.Data.Entities.Image", b =>
                {
                    b.HasOne("AppsApi.Data.Entities.App", "App")
                        .WithMany("Images")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("App");
                });

            modelBuilder.Entity("AppsApi.Data.Entities.Review", b =>
                {
                    b.HasOne("AppsApi.Data.Entities.App", "App")
                        .WithMany("Reviews")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("App");
                });

            modelBuilder.Entity("AppsApi.Data.Entities.App", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("AppsApi.Data.Entities.Developer", b =>
                {
                    b.Navigation("Apps");
                });
#pragma warning restore 612, 618
        }
    }
}
