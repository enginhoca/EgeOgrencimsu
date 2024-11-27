﻿// <auto-generated />
using System;
using EgeApp.Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EgeApp.Backend.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241126114049_EgeAppDb")]
    partial class EgeAppDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 562, DateTimeKind.Local).AddTicks(1460),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 562, DateTimeKind.Local).AddTicks(1470),
                            UserId = "2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 562, DateTimeKind.Local).AddTicks(1470),
                            UserId = "3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 562, DateTimeKind.Local).AddTicks(1480),
                            UserId = "4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 562, DateTimeKind.Local).AddTicks(1480),
                            UserId = "5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 562, DateTimeKind.Local).AddTicks(1480),
                            UserId = "6"
                        });
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EgeApp.Backend.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ortopedik ürünler",
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ortopedik Ürünler",
                            Url = "ortopedik-urunler"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Solunum cihazları",
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Solunum Cihazları",
                            Url = "solunum-cihazlari"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Solunum maskeleri",
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Solunum Maskeleri",
                            Url = "solunum-maskeleri"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hasta bakım ürünleri",
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hasta Bakım Ürünleri",
                            Url = "hasta-bakim-urunleri"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tıbbi test ve sarf malzemeleri",
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tıbbi Test ve Sarf Malzemeleri",
                            Url = "tibbi-test-ve-sarf-malzemeleri"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tansiyon ve nabız ölçüm cihazları",
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tansiyon ve Nabız Ölçüm Cihazları",
                            Url = "tansiyon-ve-nabiz-olcum-cihazlari"
                        });
                });

            modelBuilder.Entity("EgeApp.Backend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("DiscountedPrice")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDiscounted")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsFreeShipping")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsLimitedStock")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsSameDayShipping")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsSpecialProduct")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ManufacturingDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("PrescriptionRequired")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StockCode")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("StorageConditions")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsageInstructions")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("WarrantyPeriod")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6320),
                            Description = "Diz ve sırt destekleyici",
                            ImageUrl = "http://localhost:5200/images/products/dorselumberkorse.webp",
                            IsActive = true,
                            IsDiscounted = false,
                            IsFreeShipping = true,
                            IsHome = true,
                            IsLimitedStock = false,
                            IsSameDayShipping = true,
                            IsSpecialProduct = false,
                            ModifiedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6330),
                            Name = "Dorselumber Korse",
                            Price = 1000m,
                            ProductCategoryId = 1,
                            Url = "dorselumber-korse"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6340),
                            Description = "Profesyonel solunum cihazı",
                            ImageUrl = "http://localhost:5200/images/products/devisbissoksijen.webp",
                            IsActive = true,
                            IsDiscounted = false,
                            IsFreeShipping = true,
                            IsHome = true,
                            IsLimitedStock = false,
                            IsSameDayShipping = true,
                            IsSpecialProduct = false,
                            ModifiedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6340),
                            Name = "Devisbiss Oksijen Konsantratörü",
                            Price = 8000m,
                            ProductCategoryId = 2,
                            Url = "devisbiss-oksijen-konsantratoru"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6350),
                            Description = "Solunum desteği için maske",
                            ImageUrl = "http://localhost:5200/images/products/tamyuzmaskesi.webp",
                            IsActive = true,
                            IsDiscounted = false,
                            IsFreeShipping = true,
                            IsHome = true,
                            IsLimitedStock = false,
                            IsSameDayShipping = true,
                            IsSpecialProduct = false,
                            ModifiedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6350),
                            Name = "Tam Yüz Maskesi",
                            Price = 500m,
                            ProductCategoryId = 3,
                            Url = "tam-yuz-maskesi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6350),
                            Description = "Hasta bakım için motorlu yatak",
                            ImageUrl = "http://localhost:5200/images/products/motorluhastakaryolasi.webp",
                            IsActive = true,
                            IsDiscounted = false,
                            IsFreeShipping = true,
                            IsHome = true,
                            IsLimitedStock = false,
                            IsSameDayShipping = true,
                            IsSpecialProduct = false,
                            ModifiedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6350),
                            Name = "2 Motorlu Hasta Karyolası",
                            Price = 12000m,
                            ProductCategoryId = 4,
                            Url = "2-motorlu-hasta-karyolasi"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6360),
                            Description = "Hızlı tıbbi test malzemesi",
                            ImageUrl = "http://localhost:5200/images/products/wcuracdbg.webp",
                            IsActive = true,
                            IsDiscounted = false,
                            IsFreeShipping = true,
                            IsHome = true,
                            IsLimitedStock = false,
                            IsSameDayShipping = true,
                            IsSpecialProduct = false,
                            ModifiedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6360),
                            Name = "W Cura C",
                            Price = 700m,
                            ProductCategoryId = 5,
                            Url = "w-cura-c"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6370),
                            Description = "Hassas tansiyon ölçer",
                            ImageUrl = "http://localhost:5200/images/products/tansiyonaleti.webp",
                            IsActive = true,
                            IsDiscounted = false,
                            IsFreeShipping = true,
                            IsHome = true,
                            IsLimitedStock = false,
                            IsSameDayShipping = true,
                            IsSpecialProduct = false,
                            ModifiedDate = new DateTime(2024, 11, 26, 14, 40, 49, 563, DateTimeKind.Local).AddTicks(6370),
                            Name = "Tansiyon Aleti",
                            Price = 500m,
                            ProductCategoryId = 6,
                            Url = "tansiyon-aleti"
                        });
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.CartItem", b =>
                {
                    b.HasOne("EgeApp.Backend.Entity.Concrete.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EgeApp.Backend.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.OrderItem", b =>
                {
                    b.HasOne("EgeApp.Backend.Entity.Concrete.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EgeApp.Backend.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EgeApp.Backend.Models.Category", b =>
                {
                    b.HasOne("EgeApp.Backend.Models.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("EgeApp.Backend.Models.Product", b =>
                {
                    b.HasOne("EgeApp.Backend.Models.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("EgeApp.Backend.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EgeApp.Backend.Models.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
