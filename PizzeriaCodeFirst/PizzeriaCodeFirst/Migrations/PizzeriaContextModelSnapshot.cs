﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzeriaCodeFirst.Models;

#nullable disable

namespace PizzeriaCodeFirst.Migrations
{
    [DbContext(typeof(PizzeriaContext))]
    partial class PizzeriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Klienci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Klienta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZamowienieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("Kliencis");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Menu");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa_Dania")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rabat")
                        .HasColumnType("int");

                    b.Property<int?>("ZamowienieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Pizzeria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Pizzeri");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_Produktu")
                        .HasColumnType("int");

                    b.Property<int?>("PracownikId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZamowienieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_Produktu")
                        .IsUnique();

                    b.HasIndex("PracownikId");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("Pizzerias");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Pracownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Pracownika");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PizzeriaId")
                        .HasColumnType("int");

                    b.Property<string>("Stanowisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stawka")
                        .HasColumnType("int");

                    b.Property<int?>("ZamowienieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PizzeriaId");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("Pracowniks");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Produkty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Produktu");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ilosc_Produktu")
                        .HasColumnType("int");

                    b.Property<int>("Max_Ilosc_Produktu")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa_Produktu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Produktys");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Zamowienie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Zamowienia");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_Godz")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KlientId")
                        .HasColumnType("int");

                    b.Property<int?>("MenuIId")
                        .HasColumnType("int");

                    b.Property<int?>("PizzeriaId")
                        .HasColumnType("int");

                    b.Property<int?>("PracownikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KlientId");

                    b.HasIndex("MenuIId");

                    b.HasIndex("PizzeriaId");

                    b.HasIndex("PracownikId");

                    b.ToTable("Zamowienies");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Klienci", b =>
                {
                    b.HasOne("PizzeriaCodeFirst.Models.Zamowienie", null)
                        .WithMany("Kliencis")
                        .HasForeignKey("ZamowienieId");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Menu", b =>
                {
                    b.HasOne("PizzeriaCodeFirst.Models.Zamowienie", null)
                        .WithMany("Menus")
                        .HasForeignKey("ZamowienieId");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Pizzeria", b =>
                {
                    b.HasOne("PizzeriaCodeFirst.Models.Produkty", "Produkt")
                        .WithOne("Pizzeria")
                        .HasForeignKey("PizzeriaCodeFirst.Models.Pizzeria", "ID_Produktu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzeriaCodeFirst.Models.Pracownik", null)
                        .WithMany("Pizzerias")
                        .HasForeignKey("PracownikId");

                    b.HasOne("PizzeriaCodeFirst.Models.Zamowienie", null)
                        .WithMany("Pizzerias")
                        .HasForeignKey("ZamowienieId");

                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Pracownik", b =>
                {
                    b.HasOne("PizzeriaCodeFirst.Models.Pizzeria", "Pizzeria")
                        .WithMany("Pracowniks")
                        .HasForeignKey("PizzeriaId");

                    b.HasOne("PizzeriaCodeFirst.Models.Zamowienie", null)
                        .WithMany("Pracowniks")
                        .HasForeignKey("ZamowienieId");

                    b.Navigation("Pizzeria");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Zamowienie", b =>
                {
                    b.HasOne("PizzeriaCodeFirst.Models.Klienci", "Klient")
                        .WithMany("Zamowienies")
                        .HasForeignKey("KlientId");

                    b.HasOne("PizzeriaCodeFirst.Models.Menu", "MenuI")
                        .WithMany("Zamowienies")
                        .HasForeignKey("MenuIId");

                    b.HasOne("PizzeriaCodeFirst.Models.Pizzeria", "Pizzeria")
                        .WithMany("Zamowienies")
                        .HasForeignKey("PizzeriaId");

                    b.HasOne("PizzeriaCodeFirst.Models.Pracownik", "Pracownik")
                        .WithMany("Zamowienies")
                        .HasForeignKey("PracownikId");

                    b.Navigation("Klient");

                    b.Navigation("MenuI");

                    b.Navigation("Pizzeria");

                    b.Navigation("Pracownik");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Klienci", b =>
                {
                    b.Navigation("Zamowienies");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Menu", b =>
                {
                    b.Navigation("Zamowienies");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Pizzeria", b =>
                {
                    b.Navigation("Pracowniks");

                    b.Navigation("Zamowienies");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Pracownik", b =>
                {
                    b.Navigation("Pizzerias");

                    b.Navigation("Zamowienies");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Produkty", b =>
                {
                    b.Navigation("Pizzeria");
                });

            modelBuilder.Entity("PizzeriaCodeFirst.Models.Zamowienie", b =>
                {
                    b.Navigation("Kliencis");

                    b.Navigation("Menus");

                    b.Navigation("Pizzerias");

                    b.Navigation("Pracowniks");
                });
#pragma warning restore 612, 618
        }
    }
}
