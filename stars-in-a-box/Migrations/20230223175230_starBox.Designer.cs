﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using stars_in_a_box;

#nullable disable

namespace stars_in_a_box.Migrations
{
    [DbContext(typeof(DatabaseConnection))]
    [Migration("20230223175230_starBox")]
    partial class starBox
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("stars_in_a_box.Models.Star.Star", b =>
                {
                    b.Property<int>("StarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StarID"));

                    b.Property<int?>("GalaxyID")
                        .HasColumnType("integer");

                    b.Property<long>("diameter")
                        .HasColumnType("bigint");

                    b.Property<float>("luminosity")
                        .HasColumnType("real");

                    b.Property<float>("mass")
                        .HasColumnType("real");

                    b.Property<int>("rotation")
                        .HasColumnType("integer");

                    b.Property<int>("surfaceTemperature")
                        .HasColumnType("integer");

                    b.HasKey("StarID");

                    b.HasIndex("GalaxyID");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("stars_in_a_box.Models.UniverseStructure.Galaxy", b =>
                {
                    b.Property<int>("GalaxyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GalaxyID"));

                    b.Property<int?>("GalaxyClusterID")
                        .HasColumnType("integer");

                    b.Property<float>("mass")
                        .HasColumnType("real");

                    b.Property<int>("numberOfStars")
                        .HasColumnType("integer");

                    b.Property<byte>("shape")
                        .HasColumnType("smallint");

                    b.Property<int>("size")
                        .HasColumnType("integer");

                    b.HasKey("GalaxyID");

                    b.HasIndex("GalaxyClusterID");

                    b.ToTable("Galaxies");
                });

            modelBuilder.Entity("stars_in_a_box.Models.UniverseStructure.GalaxyCluster", b =>
                {
                    b.Property<int>("GalaxyClusterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GalaxyClusterID"));

                    b.Property<float>("diameter")
                        .HasColumnType("real");

                    b.Property<int>("numberOfGalaxies")
                        .HasColumnType("integer");

                    b.Property<float>("totalMass")
                        .HasColumnType("real");

                    b.HasKey("GalaxyClusterID");

                    b.ToTable("GalaxyClusters");
                });

            modelBuilder.Entity("stars_in_a_box.Models.Star.Star", b =>
                {
                    b.HasOne("stars_in_a_box.Models.UniverseStructure.Galaxy", null)
                        .WithMany("StarList")
                        .HasForeignKey("GalaxyID");
                });

            modelBuilder.Entity("stars_in_a_box.Models.UniverseStructure.Galaxy", b =>
                {
                    b.HasOne("stars_in_a_box.Models.UniverseStructure.GalaxyCluster", null)
                        .WithMany("GalaxyList")
                        .HasForeignKey("GalaxyClusterID");
                });

            modelBuilder.Entity("stars_in_a_box.Models.UniverseStructure.Galaxy", b =>
                {
                    b.Navigation("StarList");
                });

            modelBuilder.Entity("stars_in_a_box.Models.UniverseStructure.GalaxyCluster", b =>
                {
                    b.Navigation("GalaxyList");
                });
#pragma warning restore 612, 618
        }
    }
}