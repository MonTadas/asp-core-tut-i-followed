﻿// <auto-generated />
using System;
using GameStore.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStore.API.Data.Migrations
{
    [DbContext(typeof(GameStoreContext))]
    [Migration("20250202192242_SeedGenres")]
    partial class SeedGenres
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("GameStore.API.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameStore.API.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 4,
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Open world"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Simulator"
                        },
                        new
                        {
                            Id = 7,
                            Name = "VR"
                        });
                });

            modelBuilder.Entity("GameStore.API.Entities.Game", b =>
                {
                    b.HasOne("GameStore.API.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
