﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data.Concrete;

#nullable disable

namespace StoreApp.Web.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20240627063247_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("StoreApp.Data.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Telefon",
                            Description = "En son segment Samsung",
                            Name = "Samsung S24",
                            Price = 50000m
                        },
                        new
                        {
                            Id = 2,
                            Category = "Telefon",
                            Description = "En son segment Samsung",
                            Name = "Samsung S25",
                            Price = 60000m
                        },
                        new
                        {
                            Id = 3,
                            Category = "Telefon",
                            Description = "En son segment Samsung",
                            Name = "Samsung S26",
                            Price = 70000m
                        },
                        new
                        {
                            Id = 4,
                            Category = "Telefon",
                            Description = "En son segment Samsung",
                            Name = "Samsung S27",
                            Price = 80000m
                        },
                        new
                        {
                            Id = 5,
                            Category = "Telefon",
                            Description = "En son segment Samsung",
                            Name = "Samsung S28",
                            Price = 90000m
                        },
                        new
                        {
                            Id = 6,
                            Category = "Telefon",
                            Description = "En son segment Samsung",
                            Name = "Samsung S29",
                            Price = 100000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
