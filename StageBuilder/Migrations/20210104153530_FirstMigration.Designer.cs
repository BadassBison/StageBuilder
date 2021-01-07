﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StageBuilder.Database;

namespace StageBuilder.Migrations
{
    [DbContext(typeof(StageBuilderDbContext))]
    [Migration("20210104153530_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("StageBuilder.Models.RegionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Column")
                        .HasColumnType("integer")
                        .HasColumnName("column");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("createdDate");

                    b.Property<string>("Data")
                        .HasColumnType("text")
                        .HasColumnName("data");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("lastUpdatedDate");

                    b.Property<int>("Row")
                        .HasColumnType("integer")
                        .HasColumnName("row");

                    b.Property<int>("StageId")
                        .HasColumnType("integer")
                        .HasColumnName("stageId");

                    b.HasKey("Id");

                    b.HasIndex("StageId");

                    b.ToTable("regions");
                });

            modelBuilder.Entity("StageBuilder.Models.StageEntity", b =>
                {
                    b.Property<int>("StageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("stageId")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("createdDate");

                    b.Property<int>("GameId")
                        .HasColumnType("integer")
                        .HasColumnName("gameId");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("lastUpdatedDate");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<bool>("Published")
                        .HasColumnType("boolean")
                        .HasColumnName("published");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("userId");

                    b.HasKey("StageId");

                    b.ToTable("stages");
                });

            modelBuilder.Entity("StageBuilder.Models.RegionEntity", b =>
                {
                    b.HasOne("StageBuilder.Models.StageEntity", "Stage")
                        .WithMany("Regions")
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stage");
                });

            modelBuilder.Entity("StageBuilder.Models.StageEntity", b =>
                {
                    b.Navigation("Regions");
                });
#pragma warning restore 612, 618
        }
    }
}
