﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apbd_kol2ef_rev2.Context;

#nullable disable

namespace apbd_kol2ef_rev2.Migrations
{
    [DbContext(typeof(MusicLabelsDbContext))]
    [Migration("20240610120521_AddedDataToTables2")]
    partial class AddedDataToTables2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataWydania")
                        .HasColumnType("datetime");

                    b.Property<int>("IdWytwornia")
                        .HasColumnType("int");

                    b.Property<string>("NazwaAlbumu")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdAlbum");

                    b.HasIndex("IdWytwornia");

                    b.ToTable("Album", (string)null);

                    b.HasData(
                        new
                        {
                            IdAlbum = 1,
                            DataWydania = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdWytwornia = 1,
                            NazwaAlbumu = "Album1"
                        },
                        new
                        {
                            IdAlbum = 2,
                            DataWydania = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdWytwornia = 2,
                            NazwaAlbumu = "Album2"
                        },
                        new
                        {
                            IdAlbum = 3,
                            DataWydania = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdWytwornia = 3,
                            NazwaAlbumu = "Album3"
                        });
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Muzyk", b =>
                {
                    b.Property<int>("IdMuzyk")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Pseudonim")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMuzyk");

                    b.ToTable("Muzyk", (string)null);

                    b.HasData(
                        new
                        {
                            IdMuzyk = 1,
                            Imie = "Jan",
                            Nazwisko = "Kowalski",
                            Pseudonim = "Kowal"
                        },
                        new
                        {
                            IdMuzyk = 2,
                            Imie = "Anna",
                            Nazwisko = "Nowak",
                            Pseudonim = "Nowa"
                        },
                        new
                        {
                            IdMuzyk = 3,
                            Imie = "Piotr",
                            Nazwisko = "Wiśniewski",
                            Pseudonim = "Wiśnia"
                        });
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Utwor", b =>
                {
                    b.Property<int>("IdUtwor")
                        .HasColumnType("int");

                    b.Property<double>("CzasTrwania")
                        .HasColumnType("float");

                    b.Property<int?>("IdAlbum")
                        .HasColumnType("int");

                    b.Property<string>("NazwaUtworu")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdUtwor");

                    b.HasIndex("IdAlbum");

                    b.ToTable("Utwor", (string)null);

                    b.HasData(
                        new
                        {
                            IdUtwor = 1,
                            CzasTrwania = 3.5,
                            IdAlbum = 1,
                            NazwaUtworu = "Utwor1"
                        },
                        new
                        {
                            IdUtwor = 2,
                            CzasTrwania = 4.5,
                            IdAlbum = 1,
                            NazwaUtworu = "Utwor2"
                        },
                        new
                        {
                            IdUtwor = 3,
                            CzasTrwania = 5.5,
                            IdAlbum = 2,
                            NazwaUtworu = "Utwor3"
                        },
                        new
                        {
                            IdUtwor = 4,
                            CzasTrwania = 6.5,
                            IdAlbum = 2,
                            NazwaUtworu = "Utwor4"
                        },
                        new
                        {
                            IdUtwor = 5,
                            CzasTrwania = 7.5,
                            IdAlbum = 3,
                            NazwaUtworu = "Utwor5"
                        },
                        new
                        {
                            IdUtwor = 6,
                            CzasTrwania = 8.5,
                            IdAlbum = 3,
                            NazwaUtworu = "Utwor6"
                        });
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.WykonawcaUtworu", b =>
                {
                    b.Property<int>("IdMuzyk")
                        .HasColumnType("int");

                    b.Property<int>("IdUtwor")
                        .HasColumnType("int");

                    b.HasKey("IdMuzyk", "IdUtwor");

                    b.HasIndex("IdUtwor");

                    b.ToTable("WykonawcaUtworu", (string)null);

                    b.HasData(
                        new
                        {
                            IdMuzyk = 1,
                            IdUtwor = 1
                        },
                        new
                        {
                            IdMuzyk = 2,
                            IdUtwor = 2
                        },
                        new
                        {
                            IdMuzyk = 3,
                            IdUtwor = 3
                        },
                        new
                        {
                            IdMuzyk = 1,
                            IdUtwor = 4
                        },
                        new
                        {
                            IdMuzyk = 1,
                            IdUtwor = 5
                        },
                        new
                        {
                            IdMuzyk = 2,
                            IdUtwor = 6
                        },
                        new
                        {
                            IdMuzyk = 3,
                            IdUtwor = 6
                        });
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Wytwornia", b =>
                {
                    b.Property<int>("IdWytwornia")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdWytwornia");

                    b.ToTable("Wytwornia", (string)null);

                    b.HasData(
                        new
                        {
                            IdWytwornia = 1,
                            Nazwa = "Universal Music Group"
                        },
                        new
                        {
                            IdWytwornia = 2,
                            Nazwa = "Sony Music Entertainment"
                        },
                        new
                        {
                            IdWytwornia = 3,
                            Nazwa = "Warner Music Group"
                        });
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Album", b =>
                {
                    b.HasOne("apbd_kol2ef_rev2.Entities.Wytwornia", "WytworniaNavigation")
                        .WithMany("Albumy")
                        .HasForeignKey("IdWytwornia")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Album_Wytwornia");

                    b.Navigation("WytworniaNavigation");
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Utwor", b =>
                {
                    b.HasOne("apbd_kol2ef_rev2.Entities.Album", "Album")
                        .WithMany("Utwory")
                        .HasForeignKey("IdAlbum")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("Album_Utwor");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.WykonawcaUtworu", b =>
                {
                    b.HasOne("apbd_kol2ef_rev2.Entities.Muzyk", "MuzykNavigation")
                        .WithMany("WykonawcyUtwory")
                        .HasForeignKey("IdMuzyk")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("WykonawcaUtworu_Muzyk");

                    b.HasOne("apbd_kol2ef_rev2.Entities.Utwor", "UtworNavigation")
                        .WithMany("WykonawcyUtwory")
                        .HasForeignKey("IdUtwor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("WykonawcaUtworu_Utwor");

                    b.Navigation("MuzykNavigation");

                    b.Navigation("UtworNavigation");
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Album", b =>
                {
                    b.Navigation("Utwory");
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Muzyk", b =>
                {
                    b.Navigation("WykonawcyUtwory");
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Utwor", b =>
                {
                    b.Navigation("WykonawcyUtwory");
                });

            modelBuilder.Entity("apbd_kol2ef_rev2.Entities.Wytwornia", b =>
                {
                    b.Navigation("Albumy");
                });
#pragma warning restore 612, 618
        }
    }
}
