﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Shop.Data;

namespace Online_Shop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_Shop.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            State = 0
                        });
                });

            modelBuilder.Entity("Online_Shop.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("Online_Shop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "GeForce 1090",
                            ProductPicture = "https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png",
                            ProductPrice = 199.9m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "GEFORCE RTX 3070",
                            ProductPicture = "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3070.png",
                            ProductPrice = 499.9m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "GEFORCE RTX 3060 Ti",
                            ProductPicture = "https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png",
                            ProductPrice = 399.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "GEFORCE RTX 3080",
                            ProductPicture = "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3080.png",
                            ProductPrice = 699.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductName = "GEFORCE RTX 3090",
                            ProductPicture = "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3090.png",
                            ProductPrice = 1499m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductName = "GEFORCE RTX 3070 Ti",
                            ProductPicture = "https://assets.nvidia.partners/images/png/3070-ti-back-300x198.png",
                            ProductPrice = 599.9m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductName = "GEFORCE RTX 3080 Ti",
                            ProductPicture = "https://assets.nvidia.partners/images/png/3080-ti-back-300x198.png",
                            ProductPrice = 1199.9m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductName = "Gigabyte GV-N1650OC-4GD graphics card GeForce GTX 1650 4 GB GDDR5",
                            ProductPicture = "https://assets.nvidia.partners/images/png/DE_70360651_95478353_US.png",
                            ProductPrice = 159.9m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductName = "EVGA GeForce RTX 3060 XC Black GAMING",
                            ProductPicture = "https://assets.nvidia.partners/images/png/12G-P5-3655-KR.png",
                            ProductPrice = 329.9m
                        },
                        new
                        {
                            ProductId = 10,
                            ProductName = "Gigabyte GeForce RTX 3070 EAGLE 8G",
                            ProductPicture = "https://assets.nvidia.partners/images/png/GV-N3070EAGLE-8GD.png",
                            ProductPrice = 499.9m
                        },
                        new
                        {
                            ProductId = 11,
                            ProductName = "ASUS DUAL-RTX3070-8G",
                            ProductPicture = "https://assets.nvidia.partners/images/png/DUAL-RTX3070-8G.png",
                            ProductPrice = 624.9m
                        },
                        new
                        {
                            ProductId = 12,
                            ProductName = "GIGABYTE GeForce GTX 1650 SUPER OC 4G",
                            ProductPicture = "https://assets.nvidia.partners/images/png/GV-N165SOC-4GD.png",
                            ProductPrice = 159.9m
                        },
                        new
                        {
                            ProductId = 13,
                            ProductName = "ASUS Pheonix RTX 3050 8G",
                            ProductPicture = "https://assets.nvidia.partners/images/png/PH-RTX3050-8G.png",
                            ProductPrice = 249.9m
                        });
                });

            modelBuilder.Entity("Online_Shop.Models.CartItem", b =>
                {
                    b.HasOne("Online_Shop.Models.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId");

                    b.HasOne("Online_Shop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Online_Shop.Models.Cart", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
