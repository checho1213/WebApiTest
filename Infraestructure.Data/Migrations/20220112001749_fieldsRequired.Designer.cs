﻿// <auto-generated />
using System;
using Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestructure.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220112001749_fieldsRequired")]
    partial class fieldsRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Infraestructure.Data.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Infraestructure.Data.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeInternal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Infraestructure.Data.Entities.PropertyImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyImages");
                });

            modelBuilder.Entity("Infraestructure.Data.Entities.PropertyTrace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateSale")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyTraces");
                });

            modelBuilder.Entity("Infraestructure.Data.Entities.Property", b =>
                {
                    b.HasOne("Infraestructure.Data.Entities.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Infraestructure.Data.Entities.PropertyImage", b =>
                {
                    b.HasOne("Infraestructure.Data.Entities.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Infraestructure.Data.Entities.PropertyTrace", b =>
                {
                    b.HasOne("Infraestructure.Data.Entities.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId");

                    b.Navigation("Property");
                });
#pragma warning restore 612, 618
        }
    }
}
