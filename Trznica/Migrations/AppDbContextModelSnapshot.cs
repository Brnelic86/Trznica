﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trznica.Data;

#nullable disable

namespace Trznica.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Trznica.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OIB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VrstaKorisnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Trznica.Models.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatumRacuna")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Iznos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RacunKorisnik")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipRacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("Trznica.Models.Stol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RedniBroj")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StolTrznica")
                        .HasColumnType("int");

                    b.Property<int>("StolVrstaStola")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stol");
                });

            modelBuilder.Entity("Trznica.Models.Ugovor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumOdobrenja")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Iznos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RedniBroj")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipUgovora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UgovorKorsinik")
                        .HasColumnType("int");

                    b.Property<int>("UgovorStol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ugovor");
                });

            modelBuilder.Entity("Trznica.Models.VrstaStola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CijenaDan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CijenaGodina")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CijenaMjesec")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VrstaStola");
                });

            modelBuilder.Entity("Trznica.Models.ZahtjevUgovor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatumZahtjeva")
                        .HasColumnType("datetime2");

                    b.Property<int>("RedniBroj")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipUgovora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZahtjevUgovorKorisnik")
                        .HasColumnType("int");

                    b.Property<int>("ZahtjevUgovorStol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ZahtjevUgovor");
                });
#pragma warning restore 612, 618
        }
    }
}
