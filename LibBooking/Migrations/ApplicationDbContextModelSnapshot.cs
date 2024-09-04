﻿// <auto-generated />
using System;
using LibBooking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibBooking.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibBooking.Models.Librarian", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectGuidesUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Librarians");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Campus = "Porirua Campus",
                            Email = "judith.hall@wandw.ac.nz",
                            ImageUrl = "/images/judith.jpg",
                            Name = "Judith Hall",
                            SubjectGuidesUrl = "https://whitireia.libguides.com/prf.php?id=c998c597-7bd7-11ed-9738-0ae0bf56cf20"
                        },
                        new
                        {
                            ID = 2,
                            Campus = "Te Auaha Campus",
                            Email = "sarah.knox@wandw.ac.nz",
                            ImageUrl = "/images/sarah.jpg",
                            Name = "Sarah Knox",
                            SubjectGuidesUrl = "https://whitireia.libguides.com/prf.php?id=c9a972af-7bd7-11ed-9738-0ae0bf56cf20"
                        },
                        new
                        {
                            ID = 3,
                            Campus = "Petone Campus",
                            Email = "madeleine.bowles@wandw.ac.nz",
                            ImageUrl = "/images/maddie.jpg",
                            Name = "Maddie Bowles",
                            SubjectGuidesUrl = "https://whitireia.libguides.com/prf.php?id=c9a970c8-7bd7-11ed-9738-0ae0bf56cf20"
                        });
                });

            modelBuilder.Entity("LibBooking.Models.LibrarianAppointment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("LibrarianID")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LibrarianID");

                    b.ToTable("LibrarianAppointments");
                });

            modelBuilder.Entity("LibBooking.Models.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("ID");

                    b.HasIndex("RoomID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("LibBooking.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Capacity = 10,
                            Description = "Description for Room A",
                            RoomName = "Room A"
                        },
                        new
                        {
                            ID = 2,
                            Capacity = 20,
                            Description = "Description for Room B",
                            RoomName = "Room B"
                        },
                        new
                        {
                            ID = 3,
                            Capacity = 30,
                            Description = "Description for Room C",
                            RoomName = "Room C"
                        },
                        new
                        {
                            ID = 4,
                            Capacity = 40,
                            Description = "Description for Room D",
                            RoomName = "Room D"
                        });
                });

            modelBuilder.Entity("LibBooking.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<< HEAD
<<<<<<< Updated upstream
                            Id = "918429d0-15ea-4637-b28b-2a59a992fd64",
=======
                            Id = "97688feb-9e4f-4962-83cf-dcaa9bb087fe",
>>>>>>> Stashed changes
=======
                            Id = "97688feb-9e4f-4962-83cf-dcaa9bb087fe",
>>>>>>> a43821dd56e1679e39ea1264e68e3a2350407b5d
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<< HEAD
<<<<<<< Updated upstream
                            Id = "df380cff-abd7-4380-9395-29ab0fc2649e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7be84570-2b5c-4039-ad77-a0d9cb7776c4",
=======
                            Id = "6fb284e0-91ae-457c-aedc-ec0742c3d421",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "115037b2-a9e5-44a7-8150-2f6d71b2e155",
>>>>>>> Stashed changes
=======
                            Id = "6fb284e0-91ae-457c-aedc-ec0742c3d421",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "115037b2-a9e5-44a7-8150-2f6d71b2e155",
>>>>>>> a43821dd56e1679e39ea1264e68e3a2350407b5d
                            Email = "admin@library.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LIBRARY.COM",
                            NormalizedUserName = "ADMIN@LIBRARY.COM",
<<<<<<< HEAD
<<<<<<< Updated upstream
                            PasswordHash = "AQAAAAIAAYagAAAAEBly2PPjCarPCCgQC/bGG7v2euC/mqSxKc4pvkz2W5CUp/QrJ/XYN4sgj5L+/semRA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cb7d83c4-b3d3-4be3-97ac-3bc4cbedc17e",
=======
                            PasswordHash = "AQAAAAIAAYagAAAAEL32Y1EqgaMmaJDICu6vLpoYiuYCrGRhQGI6NTW0SxlfKI2nL8B5Hb095XX0Vpv6kQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "96bd421e-1b55-47d1-b18b-f17ef4987ad8",
>>>>>>> Stashed changes
=======
                            PasswordHash = "AQAAAAIAAYagAAAAEL32Y1EqgaMmaJDICu6vLpoYiuYCrGRhQGI6NTW0SxlfKI2nL8B5Hb095XX0Vpv6kQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "96bd421e-1b55-47d1-b18b-f17ef4987ad8",
>>>>>>> a43821dd56e1679e39ea1264e68e3a2350407b5d
                            TwoFactorEnabled = false,
                            UserName = "admin@library.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<< HEAD
<<<<<<< Updated upstream
                            UserId = "df380cff-abd7-4380-9395-29ab0fc2649e",
                            RoleId = "918429d0-15ea-4637-b28b-2a59a992fd64"
=======
                            UserId = "6fb284e0-91ae-457c-aedc-ec0742c3d421",
                            RoleId = "97688feb-9e4f-4962-83cf-dcaa9bb087fe"
>>>>>>> Stashed changes
=======
                            UserId = "6fb284e0-91ae-457c-aedc-ec0742c3d421",
                            RoleId = "97688feb-9e4f-4962-83cf-dcaa9bb087fe"
>>>>>>> a43821dd56e1679e39ea1264e68e3a2350407b5d
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LibBooking.Models.LibrarianAppointment", b =>
                {
                    b.HasOne("LibBooking.Models.Librarian", "Librarian")
                        .WithMany()
                        .HasForeignKey("LibrarianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Librarian");
                });

            modelBuilder.Entity("LibBooking.Models.Reservation", b =>
                {
                    b.HasOne("LibBooking.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
