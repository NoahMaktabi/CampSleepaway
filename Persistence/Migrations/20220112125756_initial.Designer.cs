﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220112125756_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Cabin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CounselorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cabins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CounselorId = 0,
                            Name = "First"
                        },
                        new
                        {
                            Id = 2,
                            CounselorId = 0,
                            Name = "Second"
                        },
                        new
                        {
                            Id = 3,
                            CounselorId = 0,
                            Name = "Third"
                        },
                        new
                        {
                            Id = 4,
                            CounselorId = 0,
                            Name = "Fourth"
                        },
                        new
                        {
                            Id = 5,
                            CounselorId = 0,
                            Name = "Fifth"
                        });
                });

            modelBuilder.Entity("Domain.Camper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CabinId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CabinId");

                    b.ToTable("Campers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CabinId = 1,
                            DateOfBirth = new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(3124),
                            Name = "Niklas",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 2,
                            CabinId = 1,
                            DateOfBirth = new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4006),
                            Name = "Maja",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 3,
                            CabinId = 1,
                            DateOfBirth = new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4027),
                            Name = "Lina",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 4,
                            CabinId = 1,
                            DateOfBirth = new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4034),
                            Name = "Paula",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 5,
                            CabinId = 2,
                            DateOfBirth = new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4043),
                            Name = "Anders",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 6,
                            CabinId = 2,
                            DateOfBirth = new DateTime(2014, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4063),
                            Name = "Ahmed",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 7,
                            CabinId = 2,
                            DateOfBirth = new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4069),
                            Name = "Erik",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 8,
                            CabinId = 2,
                            DateOfBirth = new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4076),
                            Name = "Frida",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 9,
                            CabinId = 3,
                            DateOfBirth = new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4155),
                            Name = "Paul",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 10,
                            CabinId = 3,
                            DateOfBirth = new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4165),
                            Name = "Mikael",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 11,
                            CabinId = 3,
                            DateOfBirth = new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4171),
                            Name = "John",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 12,
                            CabinId = 3,
                            DateOfBirth = new DateTime(2009, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4178),
                            Name = "Silvio",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 13,
                            CabinId = 4,
                            DateOfBirth = new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4184),
                            Name = "Per",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 14,
                            CabinId = 4,
                            DateOfBirth = new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4191),
                            Name = "Leo",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 15,
                            CabinId = 4,
                            DateOfBirth = new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4197),
                            Name = "Howard",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 16,
                            CabinId = 4,
                            DateOfBirth = new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4204),
                            Name = "Ross",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 17,
                            CabinId = 5,
                            DateOfBirth = new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4210),
                            Name = "Rachel",
                            PhoneNumber = "0711254895"
                        },
                        new
                        {
                            Id = 18,
                            CabinId = 5,
                            DateOfBirth = new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4219),
                            Name = "Jakob",
                            PhoneNumber = "0711254895"
                        });
                });

            modelBuilder.Entity("Domain.CamperRegistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CabinId")
                        .HasColumnType("int");

                    b.Property<int>("CamperId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CabinId");

                    b.HasIndex("CamperId")
                        .IsUnique();

                    b.ToTable("CamperRegistry");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CabinId = 1,
                            CamperId = 1,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(1446),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(3301)
                        },
                        new
                        {
                            Id = 2,
                            CabinId = 1,
                            CamperId = 2,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5388),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5445)
                        },
                        new
                        {
                            Id = 3,
                            CabinId = 1,
                            CamperId = 3,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5457),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5469)
                        },
                        new
                        {
                            Id = 4,
                            CabinId = 1,
                            CamperId = 4,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5477),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5481)
                        },
                        new
                        {
                            Id = 5,
                            CabinId = 2,
                            CamperId = 5,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5488),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5492)
                        },
                        new
                        {
                            Id = 6,
                            CabinId = 2,
                            CamperId = 6,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5516),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5523)
                        },
                        new
                        {
                            Id = 7,
                            CabinId = 2,
                            CamperId = 7,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5532),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5539)
                        },
                        new
                        {
                            Id = 8,
                            CabinId = 2,
                            CamperId = 8,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5547),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5554)
                        },
                        new
                        {
                            Id = 9,
                            CabinId = 3,
                            CamperId = 9,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5563),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5568)
                        },
                        new
                        {
                            Id = 10,
                            CabinId = 3,
                            CamperId = 10,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5581),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5587)
                        },
                        new
                        {
                            Id = 11,
                            CabinId = 3,
                            CamperId = 11,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5596),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5602)
                        },
                        new
                        {
                            Id = 12,
                            CabinId = 3,
                            CamperId = 12,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5611),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5617)
                        },
                        new
                        {
                            Id = 13,
                            CabinId = 4,
                            CamperId = 13,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5624),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5630)
                        },
                        new
                        {
                            Id = 14,
                            CabinId = 4,
                            CamperId = 14,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5638),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5644)
                        },
                        new
                        {
                            Id = 15,
                            CabinId = 4,
                            CamperId = 15,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5652),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5658)
                        },
                        new
                        {
                            Id = 16,
                            CabinId = 4,
                            CamperId = 16,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5666),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5673)
                        },
                        new
                        {
                            Id = 17,
                            CabinId = 5,
                            CamperId = 17,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5682),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5689)
                        },
                        new
                        {
                            Id = 18,
                            CabinId = 5,
                            CamperId = 18,
                            CheckIn = new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5703),
                            CheckOut = new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5710)
                        });
                });

            modelBuilder.Entity("Domain.Counselor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CabinId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CabinId")
                        .IsUnique();

                    b.ToTable("Counselors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Storgatan10",
                            CabinId = 1,
                            DateOfBirth = new DateTime(1992, 1, 12, 13, 57, 55, 492, DateTimeKind.Local).AddTicks(9541),
                            Email = "counc1@th.com",
                            Name = "Anders Counselsson",
                            PhoneNumber = "0700545641"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Göteborgsvägen 2",
                            CabinId = 2,
                            DateOfBirth = new DateTime(1999, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(547),
                            Email = "counc2@th.com",
                            Name = "Erik Test",
                            PhoneNumber = "0700274641"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Torggatan1",
                            CabinId = 3,
                            DateOfBirth = new DateTime(1996, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(626),
                            Email = "counc3@th.com",
                            Name = "Johan Svart",
                            PhoneNumber = "0703545641"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Lillegatan4",
                            CabinId = 4,
                            DateOfBirth = new DateTime(1993, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(643),
                            Email = "counc4@th.com",
                            Name = "Jimmie Svensson",
                            PhoneNumber = "0787445641"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Kunggatan3",
                            CabinId = 5,
                            DateOfBirth = new DateTime(1997, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(654),
                            Email = "counc5@th.com",
                            Name = "Maja Andersson",
                            PhoneNumber = "0700543421"
                        });
                });

            modelBuilder.Entity("Domain.CounselorRegistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignmentEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AssignmentStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("CabinId")
                        .HasColumnType("int");

                    b.Property<int>("CounselorId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CabinId");

                    b.HasIndex("CounselorId")
                        .IsUnique();

                    b.ToTable("CounselorRegistries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignmentEnd = new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(843),
                            AssignmentStart = new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(196),
                            CabinId = 1,
                            CounselorId = 1
                        },
                        new
                        {
                            Id = 2,
                            AssignmentEnd = new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1408),
                            AssignmentStart = new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1392),
                            CabinId = 2,
                            CounselorId = 2
                        },
                        new
                        {
                            Id = 3,
                            AssignmentEnd = new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1428),
                            AssignmentStart = new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1420),
                            CabinId = 3,
                            CounselorId = 3
                        },
                        new
                        {
                            Id = 4,
                            AssignmentEnd = new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1444),
                            AssignmentStart = new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1437),
                            CabinId = 4,
                            CounselorId = 4
                        },
                        new
                        {
                            Id = 5,
                            AssignmentEnd = new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1461),
                            AssignmentStart = new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1454),
                            CabinId = 5,
                            CounselorId = 5
                        });
                });

            modelBuilder.Entity("Domain.NextOfKin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CamperId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CamperId");

                    b.ToTable("NextOfKins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Gata6",
                            CamperId = 1,
                            Email = "parent1@test.com",
                            Name = "Ken",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Gata7",
                            CamperId = 2,
                            Email = "parent2@test.com",
                            Name = "Anders",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Gata8",
                            CamperId = 3,
                            Email = "parent3@test.com",
                            Name = "Lina",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Gata4",
                            CamperId = 4,
                            Email = "parent4@test.com",
                            Name = "Per",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Gata5",
                            CamperId = 5,
                            Email = "parent5@test.com",
                            Name = "Mikael",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Gata1",
                            CamperId = 6,
                            Email = "parent6@test.com",
                            Name = "Johnny",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Gata45",
                            CamperId = 7,
                            Email = "parent7@test.com",
                            Name = "Leonard",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Gata54",
                            CamperId = 8,
                            Email = "parent8@test.com",
                            Name = "Ross",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Gata42",
                            CamperId = 9,
                            Email = "parent9@test.com",
                            Name = "Chandler",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 10,
                            Address = "Gata64",
                            CamperId = 10,
                            Email = "parent10@test.com",
                            Name = "Gunther",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 11,
                            Address = "Gata61",
                            CamperId = 11,
                            Email = "parent11@test.com",
                            Name = "Joey",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 12,
                            Address = "Gata45",
                            CamperId = 12,
                            Email = "parent12@test.com",
                            Name = "Josef",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 13,
                            Address = "Gata25",
                            CamperId = 13,
                            Email = "parent13@test.com",
                            Name = "Stefan",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 14,
                            Address = "Gata48",
                            CamperId = 14,
                            Email = "parent14@test.com",
                            Name = "Fredrick",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 15,
                            Address = "Gata66",
                            CamperId = 15,
                            Email = "parent15@test.com",
                            Name = "Marco",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 16,
                            Address = "Gata69",
                            CamperId = 16,
                            Email = "parent16@test.com",
                            Name = "Polo",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 17,
                            Address = "Gata74",
                            CamperId = 17,
                            Email = "parent17@test.com",
                            Name = "Cameron",
                            PhoneNumber = "071254864"
                        },
                        new
                        {
                            Id = 18,
                            Address = "Gata87",
                            CamperId = 18,
                            Email = "parent18@test.com",
                            Name = "Mitchel",
                            PhoneNumber = "071254864"
                        });
                });

            modelBuilder.Entity("Domain.Camper", b =>
                {
                    b.HasOne("Domain.Cabin", "Cabin")
                        .WithMany("Campers")
                        .HasForeignKey("CabinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabin");
                });

            modelBuilder.Entity("Domain.CamperRegistry", b =>
                {
                    b.HasOne("Domain.Cabin", "Cabin")
                        .WithMany()
                        .HasForeignKey("CabinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Camper", "Camper")
                        .WithOne()
                        .HasForeignKey("Domain.CamperRegistry", "CamperId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cabin");

                    b.Navigation("Camper");
                });

            modelBuilder.Entity("Domain.Counselor", b =>
                {
                    b.HasOne("Domain.Cabin", "Cabin")
                        .WithOne("Counselor")
                        .HasForeignKey("Domain.Counselor", "CabinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabin");
                });

            modelBuilder.Entity("Domain.CounselorRegistry", b =>
                {
                    b.HasOne("Domain.Cabin", "Cabin")
                        .WithMany()
                        .HasForeignKey("CabinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Counselor", "Counselor")
                        .WithOne()
                        .HasForeignKey("Domain.CounselorRegistry", "CounselorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cabin");

                    b.Navigation("Counselor");
                });

            modelBuilder.Entity("Domain.NextOfKin", b =>
                {
                    b.HasOne("Domain.Camper", "Camper")
                        .WithMany("NextOfKins")
                        .HasForeignKey("CamperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camper");
                });

            modelBuilder.Entity("Domain.Cabin", b =>
                {
                    b.Navigation("Campers");

                    b.Navigation("Counselor");
                });

            modelBuilder.Entity("Domain.Camper", b =>
                {
                    b.Navigation("NextOfKins");
                });
#pragma warning restore 612, 618
        }
    }
}