﻿// <auto-generated />
using Bazy_Danych.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bazy_Danych.Migrations
{
    [DbContext(typeof(Bazy_Context))]
    [Migration("20230509094514_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirst.Models._Uczen", b =>
                {
                    b.Property<int>("Id_ucznia")
                        .HasColumnType("int");

                    b.Property<int>("Id_grupy")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_ucznia");

                    b.ToTable("Uczen");
                });

            modelBuilder.Entity("Confurnce.Models._Grupa", b =>
                {
                    b.Property<int>("Id_Grupy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Grupy"));

                    b.Property<int>("Id_Prowadzoncego")
                        .HasColumnType("int");

                    b.Property<int>("Rok")
                        .HasColumnType("int");

                    b.HasKey("Id_Grupy");

                    b.HasIndex("Id_Prowadzoncego");

                    b.ToTable("Grupa");
                });

            modelBuilder.Entity("Confurnce.Models._Praca", b =>
                {
                    b.Property<int>("Id_pracy")
                        .HasColumnType("int");

                    b.Property<int>("Czy_ukonczony")
                        .HasColumnType("int");

                    b.Property<int>("Id_projektu")
                        .HasColumnType("int");

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.Property<int>("Zawartosc_pracy")
                        .HasColumnType("int");

                    b.Property<int>("nr_etapu")
                        .HasColumnType("int");

                    b.HasKey("Id_pracy");

                    b.ToTable("Praca");
                });

            modelBuilder.Entity("Confurnce.Models._Projekt", b =>
                {
                    b.Property<int>("Id_projektu")
                        .HasColumnType("int");

                    b.Property<int>("Id_ucznia")
                        .HasColumnType("int");

                    b.Property<int>("Licza_etapow")
                        .HasColumnType("int");

                    b.Property<int>("Liczba_ukonczonych_etapow")
                        .HasColumnType("int");

                    b.HasKey("Id_projektu");

                    b.ToTable("Projekt");
                });

            modelBuilder.Entity("Confurnce.Models._Prowadzoncy", b =>
                {
                    b.Property<int>("Id_Prowadzoncego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Prowadzoncego"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Prowadzoncego");

                    b.ToTable("Prowadzoncy");
                });

            modelBuilder.Entity("CodeFirst.Models._Uczen", b =>
                {
                    b.HasOne("Confurnce.Models._Grupa", "Grupa")
                        .WithMany("Uczen")
                        .HasForeignKey("Id_ucznia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupa");
                });

            modelBuilder.Entity("Confurnce.Models._Grupa", b =>
                {
                    b.HasOne("Confurnce.Models._Prowadzoncy", "Prowadzoncy")
                        .WithMany("Grupa")
                        .HasForeignKey("Id_Prowadzoncego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prowadzoncy");
                });

            modelBuilder.Entity("Confurnce.Models._Praca", b =>
                {
                    b.HasOne("Confurnce.Models._Projekt", "Projekt")
                        .WithMany("Praca")
                        .HasForeignKey("Id_pracy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projekt");
                });

            modelBuilder.Entity("Confurnce.Models._Projekt", b =>
                {
                    b.HasOne("CodeFirst.Models._Uczen", "Uczen")
                        .WithMany("Projekt")
                        .HasForeignKey("Id_projektu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uczen");
                });

            modelBuilder.Entity("CodeFirst.Models._Uczen", b =>
                {
                    b.Navigation("Projekt");
                });

            modelBuilder.Entity("Confurnce.Models._Grupa", b =>
                {
                    b.Navigation("Uczen");
                });

            modelBuilder.Entity("Confurnce.Models._Projekt", b =>
                {
                    b.Navigation("Praca");
                });

            modelBuilder.Entity("Confurnce.Models._Prowadzoncy", b =>
                {
                    b.Navigation("Grupa");
                });
#pragma warning restore 612, 618
        }
    }
}
