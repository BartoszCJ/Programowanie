using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace PizzeriaCodeFirst.Models;

public partial class PizzeriaContext : DbContext
{
    public PizzeriaContext()
    {
    }

    public PizzeriaContext(DbContextOptions<PizzeriaContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Klienci> Kliencis { get; set; }
    public virtual DbSet<Menu> Menus { get; set; }
    public virtual DbSet<Pizzeria> Pizzerias { get; set; }
    public virtual DbSet<Pracownik> Pracowniks { get; set; }
    public virtual DbSet<Produkty> Produktys { get; set; }
    public virtual DbSet<Zamowienie> Zamowienies { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Pizzeria;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Klienci>()
                .HasMany(e => e.Zamowienies)
                .WithOne(e => e.Klient);



        modelBuilder.Entity<Menu>()
                .HasMany(e => e.Zamowienies)
                .WithOne(e => e.MenuI);

        modelBuilder.Entity<Pracownik>()
               .HasMany(e => e.Zamowienies)
               .WithOne(e => e.Pracownik);

        modelBuilder.Entity<Pizzeria>()
               .HasMany(e => e.Zamowienies)
               .WithOne(e => e.Pizzeria);

        modelBuilder.Entity<Pizzeria>()
              .HasMany(e => e.Pracowniks)
              .WithOne(e => e.Pizzeria);

        modelBuilder.Entity<Produkty>()
             .HasOne(e => e.Pizzeria)
             .WithOne(e => e.Produkt)
            .HasForeignKey<Pizzeria>(p => p.ID_Produktu);

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
