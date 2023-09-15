using System;
using Technossus_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Technossus_Assignment;

#nullable disable

namespace ExtraEdgeApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Technossus_Assignment.Models.Students", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("StudentName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FatherNameName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("MotherNameName")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Age")
                    .HasColumnType("int");

                b.Property<string>("HomeAddress")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("RegistrationDate")
                    .HasColumnType("DateTime");

                b.Property<string>("IsDeleted")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("students");
            });

            modelBuilder.Entity("Technossus_Assignment.Models.SoftDeletes", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("TableName")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("RecordId")
                    .HasColumnType("int");

                b.Property<DateTime>("DeletedAt")
                    .HasColumnType("DateTime");

                b.HasKey("Id");

                b.ToTable("softDeletes");
            });

        }
    }
}
