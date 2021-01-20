﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MsSqlDb.EfDataProvider;

namespace MsSqlDb.EfDataProvider.Migrations
{
    [DbContext(typeof(WebShopItemsContext))]
    [Migration("20210120135635_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ItAcademyWebShop.Items.Items.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ItemId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ItAcademyWebShop.Items.Items.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ItAcademyWebShop.Items.Items.Category", b =>
                {
                    b.HasOne("ItAcademyWebShop.Items.Items.Item", null)
                        .WithMany("Categories")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("ItAcademyWebShop.Items.Items.Item", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}