using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public partial class FilamentenlijstContext : DbContext
    {

        public FilamentenlijstContext(DbContextOptions<FilamentenlijstContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Filament> Filamenten { get; set; }
        public virtual DbSet<Filament> Stock { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filament>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AantalKg).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KostPerRol).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.AantalMeter).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
