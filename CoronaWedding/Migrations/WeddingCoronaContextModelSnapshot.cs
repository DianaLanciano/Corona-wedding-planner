﻿// <auto-generated />
using System;
using CoronaWedding.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoronaWedding.Migrations
{
    [DbContext(typeof(WeddingCoronaContext))]
    partial class WeddingCoronaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoronaWedding.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CateringId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("MusicId")
                        .HasColumnType("int");

                    b.Property<int?>("PhotographerId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("weddingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountId");

                    b.HasIndex("CateringId");

                    b.HasIndex("LocationId");

                    b.HasIndex("MusicId");

                    b.HasIndex("PhotographerId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("CoronaWedding.Models.Catering", b =>
                {
                    b.Property<int>("CateringId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kosher")
                        .HasColumnType("int");

                    b.Property<string>("foodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("supplireEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CateringId");

                    b.ToTable("Catering");
                });

            modelBuilder.Entity("CoronaWedding.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("placeCapacity")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("supplireEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("CoronaWedding.Models.Music", b =>
                {
                    b.Property<int>("MusicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("musicType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("supplireEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusicId");

                    b.ToTable("Music");
                });

            modelBuilder.Entity("CoronaWedding.Models.Photographer", b =>
                {
                    b.Property<int>("PhotographerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("supplireEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotographerId");

                    b.ToTable("Photographer");
                });

            modelBuilder.Entity("CoronaWedding.Models.Account", b =>
                {
                    b.HasOne("CoronaWedding.Models.Catering", "Catering")
                        .WithMany()
                        .HasForeignKey("CateringId");

                    b.HasOne("CoronaWedding.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("CoronaWedding.Models.Music", "Music")
                        .WithMany()
                        .HasForeignKey("MusicId");

                    b.HasOne("CoronaWedding.Models.Photographer", "Photographer")
                        .WithMany()
                        .HasForeignKey("PhotographerId");
                });
#pragma warning restore 612, 618
        }
    }
}
