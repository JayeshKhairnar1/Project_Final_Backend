﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VconfigDotnet.Repositories;

#nullable disable

namespace VconfigDotnet.Migrations
{
    [DbContext(typeof(VconfRepository))]
    [Migration("20240813122645_Third")]
    partial class Third
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("vconf.Models.AlternateComponent", b =>
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

                    b.HasIndex("CompId");

                    b.HasIndex("ModId");

                    b.ToTable("AlternateComponents");
                });

            modelBuilder.Entity("vconf.Models.CarDescription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarDescriptions");
                });

            modelBuilder.Entity("vconf.Models.Component", b =>
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

            modelBuilder.Entity("vconf.Models.Invoice", b =>
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

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("vconf.Models.Manufacturer", b =>
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

            modelBuilder.Entity("vconf.Models.Model", b =>
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

            modelBuilder.Entity("vconf.Models.Segment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SegName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Segments");
                });

            modelBuilder.Entity("vconf.Models.User", b =>
                {
                    b.Property<string>("Userid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GstNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("vconf.Models.Vehicle", b =>
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

            modelBuilder.Entity("vconf.Models.AlternateComponent", b =>
                {
                    b.HasOne("vconf.Models.Component", "Comp")
                        .WithMany("AlternateComponents")
                        .HasForeignKey("CompId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vconf.Models.Model", "Mod")
                        .WithMany("AlternateComponents")
                        .HasForeignKey("ModId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comp");

                    b.Navigation("Mod");
                });

            modelBuilder.Entity("vconf.Models.Manufacturer", b =>
                {
                    b.HasOne("vconf.Models.Segment", "Seg")
                        .WithMany("Manufacturers")
                        .HasForeignKey("SegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seg");
                });

            modelBuilder.Entity("vconf.Models.Model", b =>
                {
                    b.HasOne("vconf.Models.Manufacturer", "Manu")
                        .WithMany("Models")
                        .HasForeignKey("ManuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vconf.Models.Segment", "Seg")
                        .WithMany("Models")
                        .HasForeignKey("SegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manu");

                    b.Navigation("Seg");
                });

            modelBuilder.Entity("vconf.Models.Vehicle", b =>
                {
                    b.HasOne("vconf.Models.Component", "Comp")
                        .WithMany("Vehicles")
                        .HasForeignKey("CompId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vconf.Models.Model", "Mod")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comp");

                    b.Navigation("Mod");
                });

            modelBuilder.Entity("vconf.Models.Component", b =>
                {
                    b.Navigation("AlternateComponents");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("vconf.Models.Manufacturer", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("vconf.Models.Model", b =>
                {
                    b.Navigation("AlternateComponents");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("vconf.Models.Segment", b =>
                {
                    b.Navigation("Manufacturers");

                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
