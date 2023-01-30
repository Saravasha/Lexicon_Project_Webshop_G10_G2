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
    [Migration("20230130113632_gerpgork")]
    partial class gerpgork
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
                            Id = "3f6134e6-27f2-44da-91bf-076960c4fc67",
                            ConcurrencyStamp = "556d7212-c21c-4ad1-af7b-22d49f08fc01",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5555ce94-f9f8-4d01-9707-f7a060ee1fcb",
                            ConcurrencyStamp = "3cd5f5bf-b996-420f-a514-c9eb29b7010a",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "6cc0fd32-50e4-4f00-bf71-693166d38ebb",
                            ConcurrencyStamp = "9652953d-551c-4cb4-86ca-bbe397aee0d7",
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
                            UserId = "5555ce94-f9f8-4d01-9707-f7a060ee1fcb",
                            RoleId = "3f6134e6-27f2-44da-91bf-076960c4fc67"
                        },
                        new
                        {
                            UserId = "5555ce94-f9f8-4d01-9707-f7a060ee1fcb",
                            RoleId = "6cc0fd32-50e4-4f00-bf71-693166d38ebb"
                        },
                        new
                        {
                            UserId = "5555ce94-f9f8-4d01-9707-f7a060ee1fcb",
                            RoleId = "5555ce94-f9f8-4d01-9707-f7a060ee1fcb"
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
                            Id = "3f6134e6-27f2-44da-91bf-076960c4fc67",
                            AccessFailedCount = 0,
                            CartId = 1,
                            ConcurrencyStamp = "a4325426-ae5d-4e36-9b06-511c31fe2cd9",
                            CreditCardNumber = "234",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            OrderId = 1,
                            PasswordHash = "AQAAAAEAACcQAAAAEDtW1rdhZk26Cm8ijkEEj9fz6FIF2fX/xI4pVe/yr2Yz9BgTAOQa6RGqBIZRg5NZ5g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a1bfb4b3-ac9c-48dd-b176-98524281dea1",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "6cc0fd32-50e4-4f00-bf71-693166d38ebb",
                            AccessFailedCount = 0,
                            CartId = 2,
                            ConcurrencyStamp = "3d05a2e0-ed6e-4d29-bc89-4abcd397ec0e",
                            CreditCardNumber = "123",
                            Email = "karen@manager.com",
                            EmailConfirmed = false,
                            FirstName = "Karen",
                            LastName = "Managerson",
                            LockoutEnabled = false,
                            NormalizedEmail = "KAREN@MANAGER.COM",
                            NormalizedUserName = "KAREN@MANAGER.COM",
                            OrderId = 2,
                            PasswordHash = "AQAAAAEAACcQAAAAEFAQg2Dt9gFrL6rIHt4xe+u1aSvgHshlTUPM7uuVnYUe8M/qafhT7Xd+C9xNsLvV4g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "50b51813-16f9-4666-ab3b-d16a3ca9b22a",
                            TwoFactorEnabled = false,
                            UserName = "karen@manager.com"
                        },
                        new
                        {
                            Id = "5555ce94-f9f8-4d01-9707-f7a060ee1fcb",
                            AccessFailedCount = 0,
                            CartId = 3,
                            ConcurrencyStamp = "1ca042e8-2cc0-43d8-ab62-ef0c042c7d06",
                            CreditCardNumber = "123",
                            Email = "random@user.com",
                            EmailConfirmed = false,
                            FirstName = "Joe",
                            LastName = "Sixpack",
                            LockoutEnabled = false,
                            NormalizedEmail = "RANDOM@USER.COM",
                            NormalizedUserName = "RANDOM@USER.COM",
                            OrderId = 3,
                            PasswordHash = "AQAAAAEAACcQAAAAENDY8ewYQSgphipoZ7ds7eMuKzACrPMj3a8QNVEdG0ENc525ykaN5ndIWeJYWZ+qog==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7e260933-766b-441a-bfad-f144bf6f994c",
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

                    b.Property<string>("ApplicationUserViewModelUserId")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("ApplicationUserViewModelUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpectedDelivery = "4",
                            OrderDate = new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8811),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8769)
                        },
                        new
                        {
                            Id = 2,
                            ExpectedDelivery = "4",
                            OrderDate = new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8834),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8831)
                        },
                        new
                        {
                            Id = 3,
                            ExpectedDelivery = "4",
                            OrderDate = new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8846),
                            Shipped = false,
                            ShippingDate = new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8844)
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
                            ImageUrl = "/img/gerpgork.jpg",
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
                            ImageUrl = "/img/Banana.jpg",
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
                            ImageUrl = "/img/Volvo.jpg",
                            Name = "Volvo XC70",
                            Price = 500000.0,
                            Quantity = 1,
                            ShortDescription = "tb"
                        });
                });

            modelBuilder.Entity("MVC_Webshop.ViewModels.ApplicationUserViewModel", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CartId");

                    b.ToTable("ApplicationUserViewModel");
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
                    b.HasOne("MVC_Webshop.ViewModels.ApplicationUserViewModel", null)
                        .WithMany("Orders")
                        .HasForeignKey("ApplicationUserViewModelUserId");

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

            modelBuilder.Entity("MVC_Webshop.ViewModels.ApplicationUserViewModel", b =>
                {
                    b.HasOne("MVC_Webshop.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId");

                    b.Navigation("Cart");
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

            modelBuilder.Entity("MVC_Webshop.ViewModels.ApplicationUserViewModel", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
