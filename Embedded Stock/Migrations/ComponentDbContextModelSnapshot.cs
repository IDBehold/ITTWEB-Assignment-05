﻿// <auto-generated />
using Embedded_Stock.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EmbeddedStock.Migrations
{
    [DbContext(typeof(ComponentDbContext))]
    partial class ComponentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Embedded_Stock.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Embedded_Stock.Models.CategoryComponentType", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<long>("ComponentTypeId");

                    b.HasKey("CategoryId", "ComponentTypeId");

                    b.HasIndex("ComponentTypeId");

                    b.ToTable("CategoryComponentTypes");
                });

            modelBuilder.Entity("Embedded_Stock.Models.Component", b =>
                {
                    b.Property<long>("ComponentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminComment");

                    b.Property<int>("ComponentNumber");

                    b.Property<long>("ComponentTypeId");

                    b.Property<long?>("CurrentLoanInformationId");

                    b.Property<string>("SerialNo");

                    b.Property<int>("Status");

                    b.Property<string>("UserComment");

                    b.HasKey("ComponentId");

                    b.HasIndex("ComponentTypeId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("Embedded_Stock.Models.ComponentType", b =>
                {
                    b.Property<long>("ComponentTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminComment");

                    b.Property<string>("ComponentInfo");

                    b.Property<string>("ComponentName");

                    b.Property<string>("Datasheet");

                    b.Property<long?>("ImageESImageId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Location");

                    b.Property<string>("Manufacturer");

                    b.Property<int>("Status");

                    b.Property<string>("WikiLink");

                    b.HasKey("ComponentTypeId");

                    b.HasIndex("ImageESImageId");

                    b.ToTable("ComponentTypes");
                });

            modelBuilder.Entity("Embedded_Stock.Models.ESImage", b =>
                {
                    b.Property<long>("ESImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("ImageData");

                    b.Property<string>("ImageMimeType")
                        .HasMaxLength(128);

                    b.Property<byte[]>("Thumbnail");

                    b.HasKey("ESImageId");

                    b.ToTable("EsImages");
                });

            modelBuilder.Entity("Embedded_Stock.Models.CategoryComponentType", b =>
                {
                    b.HasOne("Embedded_Stock.Models.Category", "Category")
                        .WithMany("ComponentTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Embedded_Stock.Models.ComponentType", "ComponentType")
                        .WithMany("Categories")
                        .HasForeignKey("ComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Embedded_Stock.Models.Component", b =>
                {
                    b.HasOne("Embedded_Stock.Models.ComponentType")
                        .WithMany("Components")
                        .HasForeignKey("ComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Embedded_Stock.Models.ComponentType", b =>
                {
                    b.HasOne("Embedded_Stock.Models.ESImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageESImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
