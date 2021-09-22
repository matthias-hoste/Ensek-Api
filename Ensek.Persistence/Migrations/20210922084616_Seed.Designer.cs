﻿// <auto-generated />
using Ensek.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ensek.Persistence.Migrations
{
    [DbContext(typeof(EnsekDbContext))]
    [Migration("20210922084616_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ensek")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ensek.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 2344,
                            FirstName = "Tommy",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2233,
                            FirstName = "Barry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 8766,
                            FirstName = "Sally",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2345,
                            FirstName = "Jerry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2346,
                            FirstName = "Ollie",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2347,
                            FirstName = "Tara",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2348,
                            FirstName = "Tammy",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2349,
                            FirstName = "Simon",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2350,
                            FirstName = "Colin",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2351,
                            FirstName = "Gladys",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2352,
                            FirstName = "Greg",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2353,
                            FirstName = "Tony",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2355,
                            FirstName = "Arthur",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2356,
                            FirstName = "Craig",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 6776,
                            FirstName = "Laura",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 4534,
                            FirstName = "JOSH",
                            LastName = "TEST"
                        },
                        new
                        {
                            Id = 1234,
                            FirstName = "Freya",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1239,
                            FirstName = "Noddy",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1240,
                            FirstName = "Archie",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1241,
                            FirstName = "Lara",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1242,
                            FirstName = "Tim",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1243,
                            FirstName = "Graham",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1244,
                            FirstName = "Tony",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1245,
                            FirstName = "Neville",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1246,
                            FirstName = "Jo",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1247,
                            FirstName = "Jim",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 1248,
                            FirstName = "Pam",
                            LastName = "Test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
