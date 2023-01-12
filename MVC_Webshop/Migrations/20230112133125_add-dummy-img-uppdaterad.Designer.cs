﻿// <auto-generated />
using System;
using MVC_Webshop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Webshop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230112133125_add-dummy-img-uppdaterad")]
    partial class adddummyimguppdaterad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3277b0f9-1901-4210-bcf3-edc3268d6691",
                            ConcurrencyStamp = "6766151a-aa78-45d1-ae6f-d46856b6dedf",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d8fe1bbb-d128-4b02-a034-bb2c043352d0",
                            ConcurrencyStamp = "bc5fee56-c704-40d7-97e5-f2ee63cc578b",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "2135ed9f-69aa-423d-b8c0-72dbc38610b7",
                            ConcurrencyStamp = "43278256-04d5-4fd3-89ee-85e79865906f",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d8fe1bbb-d128-4b02-a034-bb2c043352d0",
                            RoleId = "3277b0f9-1901-4210-bcf3-edc3268d6691"
                        },
                        new
                        {
                            UserId = "d8fe1bbb-d128-4b02-a034-bb2c043352d0",
                            RoleId = "2135ed9f-69aa-423d-b8c0-72dbc38610b7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MVC_Webshop.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CartId")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d8fe1bbb-d128-4b02-a034-bb2c043352d0",
                            AccessFailedCount = 0,
                            CartId = 1,
                            ConcurrencyStamp = "323f20c2-01f2-4b76-95f6-fedde831a087",
                            CreditCardNumber = "234",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            OrderId = 1,
                            PasswordHash = "AQAAAAEAACcQAAAAEGtY6YnHphNCAx9jCzHlrlGjOAYKbRycJ6wc9/2ImFRNDfFzpxkzH54UZexdlc0Bjg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e6bd20eb-a458-48c4-b6af-b20a1afa7741",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "2135ed9f-69aa-423d-b8c0-72dbc38610b7",
                            AccessFailedCount = 0,
                            CartId = 2,
                            ConcurrencyStamp = "869d71dc-2ba8-4450-9e4b-b3a8707acf42",
                            CreditCardNumber = "123",
                            Email = "karen@manager.com",
                            EmailConfirmed = false,
                            FirstName = "Karen",
                            LastName = "Managerson",
                            LockoutEnabled = false,
                            NormalizedEmail = "KAREN@MANAGER.COM",
                            NormalizedUserName = "KAREN",
                            OrderId = 2,
                            PasswordHash = "AQAAAAEAACcQAAAAEDaBQyAxQHmYIDhNqxZIkSVrdTWj3iJWeRhkluQo2r+hkEgM4uvOU64gx9K917j/6w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "959521c7-19f0-4183-b5ad-1918e9fbd2a6",
                            TwoFactorEnabled = false,
                            UserName = "Karen"
                        });
                });

            modelBuilder.Entity("MVC_Webshop.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1
                        },
                        new
                        {
                            Id = 2
                        });
                });

            modelBuilder.Entity("MVC_Webshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Birds",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fruit",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bilar",
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("MVC_Webshop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductIdRef")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CartId = 1,
                            ProductIdRef = 1,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("MVC_Webshop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ExpectedDelivery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Shipped")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpectedDelivery = "4",
                            OrderDate = new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1566),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1522)
                        },
                        new
                        {
                            Id = 2,
                            ExpectedDelivery = "4",
                            OrderDate = new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1582),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1580)
                        });
                });

            modelBuilder.Entity("MVC_Webshop.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MVC_Webshop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Birdstuff",
                            CategoryId = 1,
                            Description = "it's a type of bird",
                            ImageUrl = "/img/bird.jpg",
                            Name = "Gerpgork",
                            Price = 2000.0,
                            Quantity = 1,
                            ShortDescription = "tb"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Chiquita",
                            CategoryId = 2,
                            Description = "it's a type of Banana",
                            ImageUrl = "/img/banana.jpg",
                            Name = "Banana",
                            Price = 5.0,
                            Quantity = 1,
                            ShortDescription = "tb"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Volvo",
                            CategoryId = 3,
                            Description = "it's a type of car",
                            ImageUrl = "/img/volvo.jpg",
                            Name = "Volvo XC70",
                            Price = 500000.0,
                            Quantity = 1,
                            ShortDescription = "tb"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("MVC_Webshop.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Webshop.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MVC_Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVC_Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVC_Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Webshop.Models.ApplicationUser", b =>
                {
                    b.HasOne("MVC_Webshop.Models.Cart", "Cart")
                        .WithOne("User")
                        .HasForeignKey("MVC_Webshop.Models.ApplicationUser", "CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("MVC_Webshop.Models.Item", b =>
                {
                    b.HasOne("MVC_Webshop.Models.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("MVC_Webshop.Models.Order", b =>
                {
                    b.HasOne("MVC_Webshop.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVC_Webshop.Models.OrderItem", b =>
                {
                    b.HasOne("MVC_Webshop.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MVC_Webshop.Models.ApplicationUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MVC_Webshop.Models.Cart", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Webshop.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
