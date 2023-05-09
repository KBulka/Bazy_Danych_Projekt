using CodeFirst.Models;
using Confurnce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Bazy_Danych.Entities
{
    public class Bazy_Context : DbContext
    {
        public Bazy_Context(DbContextOptions<Bazy_Context> options) : base(options)        
        {
          
        }

        public DbSet<_Grupa> Grupa { get; set; }
        public DbSet<_Praca> Praca { get; set; }
        public DbSet<_Projekt> Projekt { get; set;}
        public DbSet<_Prowadzoncy> Prowadzoncy {get; set;}
        public DbSet<_Uczen> Uczen { get; set; }
        

        //Relacje
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_Prowadzoncy>(eb =>
            {
                eb.HasMany(w => w.Grupa) // ma wiele grup
                .WithOne(c => c.Prowadzoncy)
                .HasForeignKey(c => c.Id_Prowadzoncego);
            });

            modelBuilder.Entity<_Grupa>(eb =>
            {
                eb.HasMany(w => w.Uczen)
                .WithOne(c => c.Grupa) 
                .HasForeignKey(c => c.Id_ucznia);
            });
            modelBuilder.Entity<_Uczen>(eb =>
            {
                eb.HasMany(w => w.Projekt)
                .WithOne(c => c.Uczen)
                .HasForeignKey(c => c.Id_projektu);
            });
            modelBuilder.Entity<_Projekt>(eb =>
            {
                eb.HasMany(w => w.Praca)
                .WithOne(c => c.Projekt)
                .HasForeignKey(c => c.Id_pracy);
            });

        }
    }
}
