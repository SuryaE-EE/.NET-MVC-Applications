﻿// <auto-generated />
using EfCoreCodeFirstApproach1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDemo1.Migrations
{
    [DbContext(typeof(EmpDbContext))]
    partial class EmpDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDemo1.EmployeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tblEmployees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EName = "John Doe",
                            Job = "Developer",
                            Salary = 18000
                        },
                        new
                        {
                            Id = 2,
                            EName = "Jane Smith",
                            Job = "Trainer",
                            Salary = 25000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
