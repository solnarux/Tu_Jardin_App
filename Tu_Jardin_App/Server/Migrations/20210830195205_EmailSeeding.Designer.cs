﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tu_Jardin_App.Server.Data;

namespace Tu_Jardin_App.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210830195205_EmailSeeding")]
    partial class EmailSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tu_Jardin_App.Shared.Models.Achieve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Agricultor")
                        .HasColumnType("bit");

                    b.Property<bool>("Cosecha")
                        .HasColumnType("bit");

                    b.Property<bool>("Guardabosques")
                        .HasColumnType("bit");

                    b.Property<bool>("Hermitano")
                        .HasColumnType("bit");

                    b.Property<bool>("Jardin")
                        .HasColumnType("bit");

                    b.Property<bool>("Jardinero")
                        .HasColumnType("bit");

                    b.Property<bool>("Lluvia")
                        .HasColumnType("bit");

                    b.Property<bool>("Riego")
                        .HasColumnType("bit");

                    b.Property<bool>("Semillero")
                        .HasColumnType("bit");

                    b.Property<bool>("Vida")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Achieves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Agricultor = true,
                            Cosecha = false,
                            Guardabosques = false,
                            Hermitano = false,
                            Jardin = false,
                            Jardinero = false,
                            Lluvia = false,
                            Riego = false,
                            Semillero = true,
                            Vida = false
                        },
                        new
                        {
                            Id = 2,
                            Agricultor = false,
                            Cosecha = true,
                            Guardabosques = false,
                            Hermitano = false,
                            Jardin = false,
                            Jardinero = false,
                            Lluvia = false,
                            Riego = true,
                            Semillero = false,
                            Vida = false
                        });
                });

            modelBuilder.Entity("Tu_Jardin_App.Shared.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AchievementsId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Seeddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AchievementsId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AchievementsId = 1,
                            Email = "estebanlopezb2010@gmail.com",
                            Img = "/images/Aromáticas.png",
                            Name = "Jesus",
                            Owner = "David Herrera",
                            Seeddate = new DateTime(2021, 8, 30, 14, 52, 4, 851, DateTimeKind.Local).AddTicks(4392),
                            Type = "Salvia"
                        },
                        new
                        {
                            Id = 2,
                            AchievementsId = 2,
                            Email = "estebanlopezb2010@gmail.com",
                            Img = "/images/Cannabis.png",
                            Name = "Alberto",
                            Owner = "David Herrera",
                            Seeddate = new DateTime(2021, 8, 30, 14, 52, 4, 851, DateTimeKind.Local).AddTicks(8003),
                            Type = "Cannabis Indica"
                        });
                });

            modelBuilder.Entity("Tu_Jardin_App.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Plants")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test@gmail.com",
                            Img = "/images/logros/agricultor.png",
                            Plants = 2,
                            Points = 230,
                            UserName = "Dave Herrera"
                        },
                        new
                        {
                            Id = 2,
                            Email = "test2@gmail.com",
                            Img = "/images/logros/guardabosques.png",
                            Plants = 3,
                            Points = 150,
                            UserName = "Solnarux"
                        });
                });

            modelBuilder.Entity("Tu_Jardin_App.Shared.Models.Plant", b =>
                {
                    b.HasOne("Tu_Jardin_App.Shared.Models.Achieve", "Achievements")
                        .WithMany()
                        .HasForeignKey("AchievementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievements");
                });
#pragma warning restore 612, 618
        }
    }
}
