﻿// <auto-generated />
using Kostenberekening_3D_printer_ASPnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kostenberekening_3D_printer_ASPnet.Migrations
{
    [DbContext(typeof(FilamentenlijstContext))]
    [Migration("20210305183017_aantalmetertoegevoegd")]
    partial class aantalmetertoegevoegd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kostenberekening_3D_printer_ASPnet.Models.Filament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AantalKg")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("AantalMeter")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Kleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("KostPerRol")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filamenten");
                });
#pragma warning restore 612, 618
        }
    }
}
