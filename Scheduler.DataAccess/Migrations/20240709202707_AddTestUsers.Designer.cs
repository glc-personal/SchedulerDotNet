﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scheduler.DataAccess;

#nullable disable

namespace Scheduler.DataAccess.Migrations
{
    [DbContext(typeof(SchedulerDbContext))]
    [Migration("20240709202707_AddTestUsers")]
    partial class AddTestUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Scheduler.Core.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "General Manager"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Trainer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Shift Lead"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Team Member"
                        });
                });

            modelBuilder.Entity("Scheduler.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConsecutiveDaysWorked")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPhoneConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLoggedInDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinutesWorked")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConsecutiveDaysWorked = 0,
                            CreationDate = new DateTime(2024, 7, 9, 16, 27, 5, 460, DateTimeKind.Local).AddTicks(6414),
                            Email = "sam.tumaus@gmail.com",
                            FirstName = "Sam",
                            IsAdmin = true,
                            IsEmailConfirmed = false,
                            IsPhoneConfirmed = false,
                            LastLoggedInDate = new DateTime(2024, 7, 9, 16, 27, 5, 460, DateTimeKind.Local).AddTicks(6462),
                            LastName = "Tumaus",
                            MinutesWorked = 0,
                            Password = "$2a$10$3SMLe6R3LR6UYshRyaZRju/Cql/SysLN6mHfV11BVkXpIHSeUrfDG",
                            PhoneNumber = "302-507-9985",
                            ProfilePicturePath = "",
                            Status = 0,
                            Title = "Manager",
                            TitleId = 2,
                            UpdateDate = new DateTime(2024, 7, 9, 16, 27, 5, 460, DateTimeKind.Local).AddTicks(6460),
                            Username = "default-admin"
                        },
                        new
                        {
                            Id = 2,
                            ConsecutiveDaysWorked = 0,
                            CreationDate = new DateTime(2024, 7, 9, 16, 27, 5, 507, DateTimeKind.Local).AddTicks(2791),
                            Email = "dillon.sean@gmail.com",
                            FirstName = "Dillon",
                            IsAdmin = false,
                            IsEmailConfirmed = false,
                            IsPhoneConfirmed = false,
                            LastLoggedInDate = new DateTime(2024, 7, 9, 16, 27, 5, 507, DateTimeKind.Local).AddTicks(2841),
                            LastName = "Sean",
                            MinutesWorked = 0,
                            Password = "$2a$10$Qo8yCdmvbstD1LlvknaIi.MM2kNcONJND0WajXsLyXNfORplGbbIS",
                            PhoneNumber = "302-627-9281",
                            ProfilePicturePath = "",
                            Status = 0,
                            Title = "Team Member",
                            TitleId = 5,
                            UpdateDate = new DateTime(2024, 7, 9, 16, 27, 5, 507, DateTimeKind.Local).AddTicks(2839),
                            Username = "test-team-member"
                        },
                        new
                        {
                            Id = 3,
                            ConsecutiveDaysWorked = 0,
                            CreationDate = new DateTime(2024, 7, 9, 16, 27, 5, 554, DateTimeKind.Local).AddTicks(4424),
                            Email = "kelly.green@gmail.com",
                            FirstName = "Kelly",
                            IsAdmin = false,
                            IsEmailConfirmed = false,
                            IsPhoneConfirmed = false,
                            LastLoggedInDate = new DateTime(2024, 7, 9, 16, 27, 5, 554, DateTimeKind.Local).AddTicks(4472),
                            LastName = "Green",
                            MinutesWorked = 0,
                            Password = "$2a$10$9huI47CwYt5D13O91zMqR.H2HJ30wYA7GMnyv0iMgMA2fcBdhwGZ.",
                            PhoneNumber = "717-090-4487",
                            ProfilePicturePath = "",
                            Status = 0,
                            Title = "Team Member",
                            TitleId = 5,
                            UpdateDate = new DateTime(2024, 7, 9, 16, 27, 5, 554, DateTimeKind.Local).AddTicks(4470),
                            Username = "user3-test-team-member"
                        },
                        new
                        {
                            Id = 4,
                            ConsecutiveDaysWorked = 0,
                            CreationDate = new DateTime(2024, 7, 9, 16, 27, 5, 601, DateTimeKind.Local).AddTicks(2482),
                            Email = "tom.luc@gmail.com",
                            FirstName = "Tom",
                            IsAdmin = false,
                            IsEmailConfirmed = false,
                            IsPhoneConfirmed = false,
                            LastLoggedInDate = new DateTime(2024, 7, 9, 16, 27, 5, 601, DateTimeKind.Local).AddTicks(2538),
                            LastName = "Luc",
                            MinutesWorked = 0,
                            Password = "$2a$10$V0Cb963/8yZH88AjVZbKL.96/mDX0xdTP8ZTD7QvPuL8XP1k40GVG",
                            PhoneNumber = "201-180-4464",
                            ProfilePicturePath = "",
                            Status = 0,
                            Title = "Team Member",
                            TitleId = 5,
                            UpdateDate = new DateTime(2024, 7, 9, 16, 27, 5, 601, DateTimeKind.Local).AddTicks(2527),
                            Username = "user4-test-team-member"
                        },
                        new
                        {
                            Id = 5,
                            ConsecutiveDaysWorked = 0,
                            CreationDate = new DateTime(2024, 7, 9, 16, 27, 5, 650, DateTimeKind.Local).AddTicks(4487),
                            Email = "gabby.ballio@gmail.com",
                            FirstName = "Gabby",
                            IsAdmin = false,
                            IsEmailConfirmed = false,
                            IsPhoneConfirmed = false,
                            LastLoggedInDate = new DateTime(2024, 7, 9, 16, 27, 5, 650, DateTimeKind.Local).AddTicks(4538),
                            LastName = "Ballio",
                            MinutesWorked = 0,
                            Password = "$2a$10$Aw3H5c6dtCW24T9CTYK11.QkjZN5hzg.tfYzZz0VIChwd/FY8bNbu",
                            PhoneNumber = "132-343-5542",
                            ProfilePicturePath = "",
                            Status = 0,
                            Title = "Team Member",
                            TitleId = 5,
                            UpdateDate = new DateTime(2024, 7, 9, 16, 27, 5, 650, DateTimeKind.Local).AddTicks(4536),
                            Username = "user5-test-team-member"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}