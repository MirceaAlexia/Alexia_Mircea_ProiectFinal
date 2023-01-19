﻿// <auto-generated />
using System;
using Alexia_Mircea_ProiectFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alexia_Mircea_ProiectFinal.Migrations
{
    [DbContext(typeof(Alexia_Mircea_ProiectFinalContext))]
    [Migration("20230118130236_isShipped")]
    partial class isShipped
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Alexia_Mircea_ProiectFinal.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Alexia_Mircea_ProiectFinal.Models.Clothing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Clothing");
                });

            modelBuilder.Entity("Alexia_Mircea_ProiectFinal.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClothingID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<bool>("IsShipped")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ClothingID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Alexia_Mircea_ProiectFinal.Models.Clothing", b =>
                {
                    b.HasOne("Alexia_Mircea_ProiectFinal.Models.Category", "Category")
                        .WithMany("Clothes")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Alexia_Mircea_ProiectFinal.Models.Order", b =>
                {
                    b.HasOne("Alexia_Mircea_ProiectFinal.Models.Clothing", "Clothing")
                        .WithMany()
                        .HasForeignKey("ClothingID");

                    b.Navigation("Clothing");
                });

            modelBuilder.Entity("Alexia_Mircea_ProiectFinal.Models.Category", b =>
                {
                    b.Navigation("Clothes");
                });
#pragma warning restore 612, 618
        }
    }
}
