﻿// <auto-generated />
using FamilyArchive.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FamilyArchive.Data.Migrations
{
    [DbContext(typeof(FamilyArchiveContext))]
    [Migration("20180201213106_AddedUserIdentity")]
    partial class AddedUserIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("FamilyArchive.Model.Phrase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("From")
                        .HasMaxLength(100);

                    b.Property<string>("Text")
                        .HasMaxLength(100);

                    b.Property<string>("To")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Phrase");
                });

            modelBuilder.Entity("FamilyArchive.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .HasMaxLength(500);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(200);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(200);

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(500);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50);

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(500);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UserName")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FamilyArchive.Model.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .HasMaxLength(500);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(200);

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
