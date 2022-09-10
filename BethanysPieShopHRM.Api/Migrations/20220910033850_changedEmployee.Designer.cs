﻿// <auto-generated />
using System;
using BethanysPieShopHRM.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BethanysPieShopHRM.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220910033850_changedEmployee")]
    partial class changedEmployee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Belgium"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Germany"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Japan"
                        },
                        new
                        {
                            CountryId = 6,
                            Name = "China"
                        },
                        new
                        {
                            CountryId = 7,
                            Name = "UK"
                        },
                        new
                        {
                            CountryId = 8,
                            Name = "France"
                        },
                        new
                        {
                            CountryId = 9,
                            Name = "Brazil"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Smoker")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Brussels",
                            Comment = "Lorem Ipsum",
                            CountryId = 1,
                            Email = "bethany@bethanyspieshop.com",
                            FirstName = "Bethany",
                            Gender = 1,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            Latitude = 50.850299999999997,
                            Longitude = 4.3517000000000001,
                            MaritalStatus = 1,
                            PhoneNumber = "324777888773",
                            Smoker = false,
                            Street = "Grote Markt 1",
                            Zip = "1000"
                        },
                        new
                        {
                            EmployeeId = 2,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Antwerp",
                            Comment = "Lorem Ipsum",
                            CountryId = 2,
                            Email = "gill@bethanyspieshop.com",
                            FirstName = "Gill",
                            Gender = 0,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2017, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Cleeren",
                            Latitude = 50.850299999999997,
                            Longitude = 4.3517000000000001,
                            MaritalStatus = 0,
                            PhoneNumber = "33999909923",
                            Smoker = false,
                            Street = "New Street",
                            Zip = "2000"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.JobCategory", b =>
                {
                    b.Property<int>("JobCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobCategoryId"), 1L, 1);

                    b.Property<string>("JobCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobCategoryId");

                    b.ToTable("JobCategories");

                    b.HasData(
                        new
                        {
                            JobCategoryId = 1,
                            JobCategoryName = "Pie research"
                        },
                        new
                        {
                            JobCategoryId = 2,
                            JobCategoryName = "Sales"
                        },
                        new
                        {
                            JobCategoryId = 3,
                            JobCategoryName = "Management"
                        },
                        new
                        {
                            JobCategoryId = 4,
                            JobCategoryName = "Store staff"
                        },
                        new
                        {
                            JobCategoryId = 5,
                            JobCategoryName = "Finance"
                        },
                        new
                        {
                            JobCategoryId = 6,
                            JobCategoryName = "QA"
                        },
                        new
                        {
                            JobCategoryId = 7,
                            JobCategoryName = "IT"
                        },
                        new
                        {
                            JobCategoryId = 8,
                            JobCategoryName = "Cleaning"
                        },
                        new
                        {
                            JobCategoryId = 9,
                            JobCategoryName = "Bakery"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Employee", b =>
                {
                    b.HasOne("BethanysPieShopHRM.Shared.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BethanysPieShopHRM.Shared.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("JobCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
