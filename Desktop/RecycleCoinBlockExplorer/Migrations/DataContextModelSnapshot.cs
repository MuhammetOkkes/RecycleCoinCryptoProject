﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecycleCoinBlockExplorer.Data;

#nullable disable

namespace RecycleCoinBlockExplorer.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("RecycleCoinBlockExplorer.Models.Entity.Atik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Adi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarbonDegeri")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Miktar")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Atiklar");
                });

            modelBuilder.Entity("RecycleCoinBlockExplorer.Models.Entity.Kisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Yetki")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Kisiler");
                });
#pragma warning restore 612, 618
        }
    }
}
