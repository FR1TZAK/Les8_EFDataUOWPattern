﻿// <auto-generated />
using System;
using Boek.Data.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boek.Data.Migrations
{
    [DbContext(typeof(BoekDb))]
    [Migration("20201027190200_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Boek.Data.Models.Auteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Achtergrond")
                        .HasColumnType("TEXT");

                    b.Property<string>("Achternaam")
                        .HasColumnType("TEXT");

                    b.Property<string>("Afbeelding")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArtiestenNaam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Voornaam")
                        .HasColumnType("TEXT");

                    b.Property<string>("Woonplaats")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("Boek.Data.Models.Boekje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Afbeelding")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AuteurId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EAN")
                        .HasColumnType("TEXT")
                        .HasMaxLength(18);

                    b.Property<int?>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN10")
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("ISBN13")
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.Property<string>("KorteInhoud")
                        .HasColumnType("TEXT");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TaalKey")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UitgeverijId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VormId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AuteurId");

                    b.HasIndex("GenreId");

                    b.HasIndex("TaalKey");

                    b.HasIndex("UitgeverijId");

                    b.HasIndex("VormId");

                    b.ToTable("Boeken");
                });

            modelBuilder.Entity("Boek.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Doelgroep")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Boek.Data.Models.SubGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Doelgroep")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MinLeeftijd")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("SubGenres");
                });

            modelBuilder.Entity("Boek.Data.Models.Taal", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("Talen");
                });

            modelBuilder.Entity("Boek.Data.Models.Uitgeverij", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Hoofdkwartier")
                        .HasColumnType("TEXT");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Oprichter")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Uitgeverijen");
                });

            modelBuilder.Entity("Boek.Data.Models.Vorm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Digitaal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BoekVorm");
                });

            modelBuilder.Entity("Boek.Data.Models.Boekje", b =>
                {
                    b.HasOne("Boek.Data.Models.Auteur", "Auteur")
                        .WithMany()
                        .HasForeignKey("AuteurId");

                    b.HasOne("Boek.Data.Models.SubGenre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.HasOne("Boek.Data.Models.Taal", "Taal")
                        .WithMany()
                        .HasForeignKey("TaalKey");

                    b.HasOne("Boek.Data.Models.Uitgeverij", "Uitgeverij")
                        .WithMany()
                        .HasForeignKey("UitgeverijId");

                    b.HasOne("Boek.Data.Models.Vorm", "Vorm")
                        .WithMany()
                        .HasForeignKey("VormId");
                });

            modelBuilder.Entity("Boek.Data.Models.SubGenre", b =>
                {
                    b.HasOne("Boek.Data.Models.Genre", "Genre")
                        .WithMany("SubGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
