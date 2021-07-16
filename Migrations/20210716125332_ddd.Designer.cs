﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WishList.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210716125332_ddd")]
    partial class ddd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApiUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PaymentDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Name");

                    b.HasIndex("PaymentDetailsId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Entities.Models.LogData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyName");

                    b.ToTable("LogsData");
                });

            modelBuilder.Entity("Entities.Models.Offer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kpi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PayOut")
                        .HasColumnType("float");

                    b.Property<string>("PreviewLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyName");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Entities.Models.PaymentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.HasIndex("CompanyName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.RequestResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OperationType")
                        .HasColumnType("int");

                    b.Property<string>("request")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("response")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequestsResponses");
                });

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.HasOne("Entities.Models.PaymentDetails", "PaymentDetails")
                        .WithMany()
                        .HasForeignKey("PaymentDetailsId");

                    b.Navigation("PaymentDetails");
                });

            modelBuilder.Entity("Entities.Models.LogData", b =>
                {
                    b.HasOne("Entities.Models.Company", null)
                        .WithMany("logDatas")
                        .HasForeignKey("CompanyName");
                });

            modelBuilder.Entity("Entities.Models.Offer", b =>
                {
                    b.HasOne("Entities.Models.Company", null)
                        .WithMany("Offers")
                        .HasForeignKey("CompanyName");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Company", null)
                        .WithMany("CompanyUsers")
                        .HasForeignKey("CompanyName");
                });

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Navigation("CompanyUsers");

                    b.Navigation("logDatas");

                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
