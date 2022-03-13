﻿// <auto-generated />
using AndersEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AndersEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AndersEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Vår bipollen hjälper till med att öppna upp lungornas alveoler rejält.",
                            ImageUrl = "https://fincasolmark.com/wp-content/uploads/2021/07/finca-solmark-bipollen-225g.jpg",
                            Price = 150.50m,
                            Title = "Bipollen"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Vår unika avokadohonung passar perfekt till rejäla ostar och att marinera köttbitar med.",
                            ImageUrl = "https://fincasolmark.com/wp-content/uploads/2020/10/finca-solmark-honung-avokado-1.jpg",
                            Price = 129.99m,
                            Title = "Honung Avokado"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Vår mest populära honung kommer från blommorna på berget ovanför gården.",
                            ImageUrl = "https://fincasolmark.com/wp-content/uploads/2020/10/finca-solmark-honung-bergsblommor-1.jpg",
                            Price = 89.99m,
                            Title = "Honung Bergsblommor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
