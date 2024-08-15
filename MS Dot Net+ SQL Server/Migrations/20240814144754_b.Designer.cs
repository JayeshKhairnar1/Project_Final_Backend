﻿// <auto-generated />
using System;
using Grp4.repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VconfigDotnet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240814144754_b")]
    partial class b
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Grp4.models.AlternateComponent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("AltCompId")
                        .HasColumnType("bigint");

                    b.Property<long>("CompId")
                        .HasColumnType("bigint");

                    b.Property<double>("DeltaPrice")
                        .HasColumnType("float");

                    b.Property<long>("ModId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AltCompId");

                    b.HasIndex("CompId");

                    b.HasIndex("ModId");

                    b.ToTable("AlternateComponents");
                });

            modelBuilder.Entity("Grp4.models.CarDescription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("car_description");
                });

            modelBuilder.Entity("Grp4.models.Component", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CompName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("Grp4.models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("AltCompId")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("ModelPrice")
                        .HasColumnType("int");

                    b.Property<int>("OrderedQty")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Grp4.models.Manufacturer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("ManuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SegId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SegId");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Grp4.models.Model", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ManuId")
                        .HasColumnType("bigint");

                    b.Property<int>("MinQty")
                        .HasColumnType("int");

                    b.Property<string>("ModName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("SafetyRating")
                        .HasColumnType("int");

                    b.Property<int>("SegId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManuId");

                    b.HasIndex("SegId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Grp4.models.Segment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SegName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("segments");
                });

            modelBuilder.Entity("Grp4.models.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Userid"));

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GstNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("password");

                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Userid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Grp4.models.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CompId")
                        .HasColumnType("bigint");

                    b.Property<string>("CompType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsConfigurable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ModId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CompId");

                    b.HasIndex("ModId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Grp4.models.AlternateComponent", b =>
                {
                    b.HasOne("Grp4.models.Component", "AltComp")
                        .WithMany()
                        .HasForeignKey("AltCompId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Grp4.models.Component", "Comp")
                        .WithMany("AlternateComponents")
                        .HasForeignKey("CompId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Grp4.models.Model", "Mod")
                        .WithMany("AlternateComponents")
                        .HasForeignKey("ModId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AltComp");

                    b.Navigation("Comp");

                    b.Navigation("Mod");
                });

            modelBuilder.Entity("Grp4.models.Manufacturer", b =>
                {
                    b.HasOne("Grp4.models.Segment", "Seg")
                        .WithMany("Manufacturers")
                        .HasForeignKey("SegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seg");
                });

            modelBuilder.Entity("Grp4.models.Model", b =>
                {
                    b.HasOne("Grp4.models.Manufacturer", "Manu")
                        .WithMany("Models")
                        .HasForeignKey("ManuId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Grp4.models.Segment", "Seg")
                        .WithMany("Models")
                        .HasForeignKey("SegId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Manu");

                    b.Navigation("Seg");
                });

            modelBuilder.Entity("Grp4.models.Vehicle", b =>
                {
                    b.HasOne("Grp4.models.Component", "Comp")
                        .WithMany("Vehicles")
                        .HasForeignKey("CompId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Grp4.models.Model", "Mod")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comp");

                    b.Navigation("Mod");
                });

            modelBuilder.Entity("Grp4.models.Component", b =>
                {
                    b.Navigation("AlternateComponents");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Grp4.models.Manufacturer", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Grp4.models.Model", b =>
                {
                    b.Navigation("AlternateComponents");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Grp4.models.Segment", b =>
                {
                    b.Navigation("Manufacturers");

                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
