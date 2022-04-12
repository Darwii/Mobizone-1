﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20220409222206_secondcreate")]
    partial class secondcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DomainLayer.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("DomainLayer.ProductModel.Images", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ProductEntityid")
                        .HasColumnType("int");

                    b.Property<string>("imagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ProductEntityid");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DomainLayer.ProductModel.Master.MasterTable", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("masterData")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("MasterData");

                    b.Property<int?>("parantId")
                        .HasColumnType("int")
                        .HasColumnName("PerantId");

                    b.HasKey("id");

                    b.ToTable("Master");
                });

            modelBuilder.Entity("DomainLayer.ProductModel.ProductEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Model");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Name");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("productBrand")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Brand");

                    b.Property<string>("productType")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Type");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("specsid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("specsid");

                    b.ToTable("ProductModel");
                });

            modelBuilder.Entity("DomainLayer.ProductModel.Specificatiion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("camFeatures")
                        .HasColumnType("int");

                    b.Property<string>("core")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("os")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ram")
                        .HasColumnType("int");

                    b.Property<string>("simType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("storage")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Specificatiion");
                });

            modelBuilder.Entity("DomainLayer.Users.UserRegistration", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdBy")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<string>("modifiedBy")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("ModifiedOn");

                    b.HasKey("UserId");

                    b.ToTable("userRegistrations");
                });

            modelBuilder.Entity("DomainLayer.ProductModel.Images", b =>
                {
                    b.HasOne("DomainLayer.ProductModel.ProductEntity", null)
                        .WithMany("images")
                        .HasForeignKey("ProductEntityid");
                });

            modelBuilder.Entity("DomainLayer.ProductModel.ProductEntity", b =>
                {
                    b.HasOne("DomainLayer.ProductModel.Specificatiion", "specs")
                        .WithMany()
                        .HasForeignKey("specsid");

                    b.Navigation("specs");
                });

            modelBuilder.Entity("DomainLayer.ProductModel.ProductEntity", b =>
                {
                    b.Navigation("images");
                });
#pragma warning restore 612, 618
        }
    }
}
