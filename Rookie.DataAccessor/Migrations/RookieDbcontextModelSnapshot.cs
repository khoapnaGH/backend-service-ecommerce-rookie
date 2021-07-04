﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rookie.DataAccessor.Data;

namespace Rookie.DataAccessor.Migrations
{
    [DbContext(typeof(RookieDbcontext))]
    partial class RookieDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 495, DateTimeKind.Local).AddTicks(1840),
                            Description = "Mua ban cac loai thu cung",
                            Name = "Thu cung"
                        },
                        new
                        {
                            Id = new Guid("de876948-cbe2-4740-b944-030ef8e40c28"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 495, DateTimeKind.Local).AddTicks(1861),
                            Description = "Cac loai thuc an danh cho thu cung",
                            Name = "Thuc an cho Pet"
                        });
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderITemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.OrderItems", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 492, DateTimeKind.Local).AddTicks(5753),
                            Description = "Giong cho tu Chau Au",
                            Images = "/alaska.png",
                            Name = "Alaska",
                            Price = 12000000m
                        },
                        new
                        {
                            Id = new Guid("e044de2d-2183-445c-a821-0b06fec05cd4"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6308),
                            Description = "Giong cho tu Viet Nam",
                            Images = "/phuquoc.png",
                            Name = "Cho Phu Quoc",
                            Price = 8000000m
                        },
                        new
                        {
                            Id = new Guid("a742eec4-a3a1-4623-b146-97f21d227080"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6327),
                            Description = "Giong cho tu Nhat Ban",
                            Images = "/shiba.png",
                            Name = "shiba",
                            Price = 35000000m
                        },
                        new
                        {
                            Id = new Guid("290d1a74-0839-4919-a2b2-6a5bcf097757"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6333),
                            Description = "Thuc an loai tot nhat",
                            Images = "/loaiA.png",
                            Name = "Thuc an loai A",
                            Price = 3000000m
                        },
                        new
                        {
                            Id = new Guid("e3bc0d45-6f0e-4e04-b06f-9dd6ba0190f9"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6337),
                            Description = "Thuc an loai vua",
                            Images = "/loaiB.png",
                            Name = "Thuc an loai B",
                            Price = 2000000m
                        },
                        new
                        {
                            Id = new Guid("5c6ece7a-4bcc-4690-bb51-c42034178db0"),
                            CreatedDate = new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6340),
                            Description = "Thuc an loai binh thuong",
                            Images = "/loaiC.png",
                            Name = "Thuc an loai C",
                            Price = 1000000m
                        });
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"),
                            ProductId = new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285")
                        },
                        new
                        {
                            CategoryId = new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"),
                            ProductId = new Guid("e044de2d-2183-445c-a821-0b06fec05cd4")
                        },
                        new
                        {
                            CategoryId = new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"),
                            ProductId = new Guid("a742eec4-a3a1-4623-b146-97f21d227080")
                        },
                        new
                        {
                            CategoryId = new Guid("de876948-cbe2-4740-b944-030ef8e40c28"),
                            ProductId = new Guid("290d1a74-0839-4919-a2b2-6a5bcf097757")
                        },
                        new
                        {
                            CategoryId = new Guid("de876948-cbe2-4740-b944-030ef8e40c28"),
                            ProductId = new Guid("e3bc0d45-6f0e-4e04-b06f-9dd6ba0190f9")
                        },
                        new
                        {
                            CategoryId = new Guid("de876948-cbe2-4740-b944-030ef8e40c28"),
                            ProductId = new Guid("5c6ece7a-4bcc-4690-bb51-c42034178db0")
                        });
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.ProductRating", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CreatorId");

                    b.ToTable("ProductRating");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.ShoppingCart", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("ProductId", "CreatorId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Order", b =>
                {
                    b.HasOne("Rookie.DataAccessor.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.OrderItems", b =>
                {
                    b.HasOne("Rookie.DataAccessor.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rookie.DataAccessor.Entities.Product", "Products")
                        .WithOne("OrderItems")
                        .HasForeignKey("Rookie.DataAccessor.Entities.OrderItems", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.ProductCategory", b =>
                {
                    b.HasOne("Rookie.DataAccessor.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rookie.DataAccessor.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.ProductRating", b =>
                {
                    b.HasOne("Rookie.DataAccessor.Entities.Product", "Product")
                        .WithMany("ProductRatings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.ShoppingCart", b =>
                {
                    b.HasOne("Rookie.DataAccessor.Entities.Product", "Product")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("Rookie.DataAccessor.Entities.ShoppingCart", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Rookie.DataAccessor.Entities.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("ProductCategories");

                    b.Navigation("ProductRatings");

                    b.Navigation("ShoppingCart");
                });
#pragma warning restore 612, 618
        }
    }
}
