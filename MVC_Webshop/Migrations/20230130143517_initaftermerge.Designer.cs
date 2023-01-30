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
    [Migration("20230130143517_initaftermerge")]
    partial class initaftermerge
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
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
                            CategoriesId = 2,
                            ProductsId = 1
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 2
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 3
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 4
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
                            Id = "fafc1531-45ca-47ae-9e91-3aa72943dc77",
                            ConcurrencyStamp = "1a6bd4d5-48c3-47a2-af87-b1e8e1542b7b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "eec3f55c-ed29-4971-8c62-be4b9d636e68",
                            ConcurrencyStamp = "b01a2c6b-07b7-43e9-9209-f94eefffdd74",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "073854ab-8202-4824-9a10-c53f882f3b2e",
                            ConcurrencyStamp = "3d2c8854-d6a0-4c88-acb1-1ba22aed96f4",
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
                            UserId = "eec3f55c-ed29-4971-8c62-be4b9d636e68",
                            RoleId = "fafc1531-45ca-47ae-9e91-3aa72943dc77"
                        },
                        new
                        {
                            UserId = "eec3f55c-ed29-4971-8c62-be4b9d636e68",
                            RoleId = "073854ab-8202-4824-9a10-c53f882f3b2e"
                        },
                        new
                        {
                            UserId = "eec3f55c-ed29-4971-8c62-be4b9d636e68",
                            RoleId = "eec3f55c-ed29-4971-8c62-be4b9d636e68"
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

            modelBuilder.Entity("MVC_Webshop.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CartId")
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

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CartId")
                        .IsUnique()
                        .HasFilter("[CartId] IS NOT NULL");

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
                            Id = "fafc1531-45ca-47ae-9e91-3aa72943dc77",
                            AccessFailedCount = 0,
                            CartId = 1,
                            ConcurrencyStamp = "097835a4-501f-4076-ba5b-24e161831d03",
                            CreditCardNumber = "234",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            OrderId = 1,
                            PasswordHash = "AQAAAAEAACcQAAAAEBTy82BfPWymTKneYU648GevFGeZKUldmGFBOSSchSyGbBUe8B0P8RA8+kemZDz4ag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "996bcdc4-3e39-4b5a-83cb-bde3e3b87695",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "073854ab-8202-4824-9a10-c53f882f3b2e",
                            AccessFailedCount = 0,
                            CartId = 2,
                            ConcurrencyStamp = "7387d276-21a0-496e-b81c-c638a23b7e91",
                            CreditCardNumber = "123",
                            Email = "karen@manager.com",
                            EmailConfirmed = false,
                            FirstName = "Karen",
                            LastName = "Managerson",
                            LockoutEnabled = false,
                            NormalizedEmail = "KAREN@MANAGER.COM",
                            NormalizedUserName = "KAREN@MANAGER.COM",
                            OrderId = 2,
                            PasswordHash = "AQAAAAEAACcQAAAAEDYJ014TGzkeSC14UNMuW9Fnifq/4lXWfjYWx/OpwDXY0wHFGaA8swZF5L4DDq3wgQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "87e107f5-184c-4670-aec7-300f01432173",
                            TwoFactorEnabled = false,
                            UserName = "karen@manager.com"
                        },
                        new
                        {
                            Id = "eec3f55c-ed29-4971-8c62-be4b9d636e68",
                            AccessFailedCount = 0,
                            CartId = 3,
                            ConcurrencyStamp = "24e7b759-b1ef-4115-9f83-a724add122d9",
                            CreditCardNumber = "123",
                            Email = "random@user.com",
                            EmailConfirmed = false,
                            FirstName = "Joe",
                            LastName = "Sixpack",
                            LockoutEnabled = false,
                            NormalizedEmail = "RANDOM@USER.COM",
                            NormalizedUserName = "RANDOM@USER.COM",
                            OrderId = 3,
                            PasswordHash = "AQAAAAEAACcQAAAAEGU3jqj5B5WFqoQWdgdFrb0Cqez3MWuH4e2gZkvFSca5FY/EgqvfkQCfKV5dYc7LmA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1512fae7-fe04-448e-b469-227f5de65d7c",
                            TwoFactorEnabled = false,
                            UserName = "random@user.com"
                        });
                });

            modelBuilder.Entity("MVC_Webshop.Models.Cart", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

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
                        },
                        new
                        {
                            Id = 3
                        });
                });

            modelBuilder.Entity("MVC_Webshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Berry",
                            ProductId = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fruit",
                            ProductId = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Drinks",
                            ProductId = 0
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
                            ExpectedDelivery = "2",
                            OrderDate = new DateTime(2023, 1, 30, 15, 35, 17, 563, DateTimeKind.Local).AddTicks(3392),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 30, 15, 35, 17, 563, DateTimeKind.Local).AddTicks(3350)
                        },
                        new
                        {
                            Id = 2,
                            ExpectedDelivery = "2",
                            OrderDate = new DateTime(2023, 1, 30, 15, 35, 17, 563, DateTimeKind.Local).AddTicks(3410),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 30, 15, 35, 17, 563, DateTimeKind.Local).AddTicks(3407)
                        },
                        new
                        {
                            Id = 3,
                            ExpectedDelivery = "2",
                            OrderDate = new DateTime(2023, 1, 30, 15, 35, 17, 563, DateTimeKind.Local).AddTicks(3423),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 30, 15, 35, 17, 563, DateTimeKind.Local).AddTicks(3420)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Frukt & Grönt",
                            CategoryId = 0,
                            Description = "Dessa mangosar är plockade av elitpersonal djupt nere i den farliga mangodalen.",
                            ImageUrl = "/imagesProduct/8fa4535c-a692-4407-83f6-e74e4dcd903b_mango-01.jpg",
                            Name = "Mango",
                            Price = 5.0,
                            Quantity = 200,
                            ShortDescription = "Fina mango från Mangodalen"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Sura Gubben",
                            CategoryId = 0,
                            Description = "Dessa citroner som odlas på hemlig utomjordisk plats har den finaste och söta surhet som någonsin uppmätts i en citron.",
                            ImageUrl = "/imagesProduct/3aeac812-a431-4711-83b3-079816d8a7c1_lemon-01.jpg",
                            Name = "Citron",
                            Price = 4.7999999999999998,
                            Quantity = 800,
                            ShortDescription = "Färska och sura citroner"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Äppelmannen & Co",
                            CategoryId = 0,
                            Description = "Dessa härliga äpplen är odlade av äppelmannen i hans trädgård. De är friska och alltid färska. Dessa bör man passa på att köpa när de finns eftersom de är svåra att få tag i när de inte finns.",
                            ImageUrl = "/imagesProduct/c8894c3b-9e69-4a34-97fd-3296ad428e49_apple-02.jpg",
                            Name = "Gröna äpplen",
                            Price = 6.0,
                            Quantity = 140,
                            ShortDescription = "Snabba äpplen med frisk smak"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Mr Blueberry",
                            CategoryId = 0,
                            Description = "Dessa bär smakar bäst efter att man mosat en näve bär i handen och sen slickar rent fingrarna..",
                            ImageUrl = "/imagesProduct/4b518a1f-27a4-4ad6-8996-ce900469135b_blueberry-01.jpg",
                            Name = "Blåbär",
                            Price = 0.040000000000000001,
                            Quantity = 1000000,
                            ShortDescription = "Små runda blåa blåbär"
                        });
                });

            modelBuilder.Entity("MVC_Webshop.ViewModels.CategoryCreateViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryCreateViewModel");
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
                    b.HasOne("MVC_Webshop.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVC_Webshop.Data.ApplicationUser", null)
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

                    b.HasOne("MVC_Webshop.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVC_Webshop.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Webshop.Data.ApplicationUser", b =>
                {
                    b.HasOne("MVC_Webshop.Models.Cart", "Cart")
                        .WithOne("User")
                        .HasForeignKey("MVC_Webshop.Data.ApplicationUser", "CartId");

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
                    b.HasOne("MVC_Webshop.Data.ApplicationUser", "User")
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

            modelBuilder.Entity("MVC_Webshop.Data.ApplicationUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MVC_Webshop.Models.Cart", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVC_Webshop.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
