﻿// <auto-generated />
using System;
using AppsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240406130555_addUser")]
    partial class addUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6078),
                            Description = "Known for their challenging and immersive worlds.",
                            Name = "FroSoft",
                            ProfilePath = "https://localhost:7110/ImageProfiles/917f8e83-9fe1-430b-8e9e-0f84162389ea.png"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6086),
                            Description = "Renowned for their vast open-world RPGs filled with rich lore.",
                            Name = "BethSoft",
                            ProfilePath = "https://localhost:7110/ImageProfiles/39e18c53-4ec7-430f-909b-acad430a1ad8.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6087),
                            Description = "Masters of narrative-driven gameplay and memorable characters.",
                            Name = "BioWorks",
                            ProfilePath = "https://localhost:7110/ImageProfiles/2483acae-a970-43b0-b84b-1ae73b80c2e8.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6088),
                            Description = "Creators of visually stunning and inventive platformers.",
                            Name = "Insomnia Games",
                            ProfilePath = "https://localhost:7110/ImageProfiles/6cd64236-ead2-4305-b984-5f9f2921e712.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6089),
                            Description = "Experts in creating addictive loot-based shooter experiences.",
                            Name = "Gearworks",
                            ProfilePath = "https://localhost:7110/ImageProfiles/2e692f68-c87d-4586-8264-ec09216b907a.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6092),
                            Description = "Pioneers in online multiplayer gaming and epic sci-fi universes.",
                            Name = "Bungo",
                            ProfilePath = "https://localhost:7110/ImageProfiles/ec7510ef-0e9a-4004-9bb7-9bf8ce37c816.jpg"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6093),
                            Description = "Crafters of cinematic action-adventure games with depth.",
                            Name = "Sucker Punch Studios",
                            ProfilePath = "https://localhost:7110/ImageProfiles/25ad4dfc-9508-461f-a58e-468c220f401a.jpg"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6094),
                            Description = "Innovators in fast-paced action gameplay and stylish visuals.",
                            Name = "Platinum Studios",
                            ProfilePath = "https://localhost:7110/ImageProfiles/e1891256-535f-4662-b60a-5b037303464c.jpg"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6095),
                            Description = "Visionaries known for pushing the boundaries of storytelling in games.",
                            Name = "Ko Productions",
                            ProfilePath = "https://localhost:7110/ImageProfiles/d7f74d91-bbd4-4321-8078-b1092ad2d510.jpg"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(6097),
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
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5834),
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5845),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5846),
                            Name = "Role-Playing Game (RPG)"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5848),
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5849),
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5851),
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5852),
                            Name = "Platformer"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5853),
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5853),
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5856),
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5857),
                            Name = "Sandbox"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5858),
                            Name = "Stealth"
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5859),
                            Name = "Survival"
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5862),
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2024, 4, 6, 16, 5, 55, 507, DateTimeKind.Local).AddTicks(5864),
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

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("AppsApi.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
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

                    b.HasOne("AppsApi.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("App");

                    b.Navigation("User");
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
