﻿// <auto-generated />
using FoodReggie_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodReggie_1.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20241104175806_InitDb")]
    partial class InitDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("FoodReggie_1.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Carbohydrates")
                        .HasColumnType("REAL");

                    b.Property<double>("Fats")
                        .HasColumnType("REAL");

                    b.Property<string>("FoodGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Protein")
                        .HasColumnType("REAL");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
