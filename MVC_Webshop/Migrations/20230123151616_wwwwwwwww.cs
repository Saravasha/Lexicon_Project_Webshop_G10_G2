using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class wwwwwwwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCreateViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCreateViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
<<<<<<<< HEAD:MVC_Webshop/Migrations/20230123151616_wwwwwwwww.cs
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
========
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
>>>>>>>> origin/MikaelHomeCodeMerge01:MVC_Webshop/Migrations/20230124165044_init.cs
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductIdRef = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shipped = table.Column<bool>(type: "bit", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVC_Webshop/Migrations/20230123151616_wwwwwwwww.cs
                    { "17e89352-86f8-4138-8352-03640369af8f", "74da152f-a44d-497a-b985-cc733558f97b", "User", "USER" },
                    { "6c754753-efe8-49c9-9988-fb46165b6a6b", "5c88a13c-bd41-4915-b3a2-5dda9a78b236", "Admin", "ADMIN" },
                    { "f5e1eb4f-6079-4b17-88a9-0b35e22a2685", "94c4860f-eb84-42ac-bbff-850a71ebda8e", "Manager", "MANAGER" }
========
                    { "53db8c92-a481-4464-95e0-d93fb45c8195", "136717fd-aed6-4f4f-a713-005b088d88d4", "Manager", "MANAGER" },
                    { "a2534b98-d03e-4de0-bb0f-f00a9772ddbc", "5198bdb7-6e7a-4bd7-8a7b-7cbe3a6fdda4", "User", "USER" },
                    { "b59e4b4b-a157-41a6-b6d9-abc84834529f", "af857470-6eb9-4b8c-98e0-3c9145279bfd", "Admin", "ADMIN" }
>>>>>>>> origin/MikaelHomeCodeMerge01:MVC_Webshop/Migrations/20230124165044_init.cs
                });

            migrationBuilder.InsertData(
                table: "Carts",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, "Berry", 0 },
                    { 2, "Fruit", 0 },
                    { 3, "Drinks", 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ExpectedDelivery", "OrderDate", "Shipped", "ShippingDate", "UserId" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVC_Webshop/Migrations/20230123151616_wwwwwwwww.cs
                    { 1, "3", new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3868), false, new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3826), null },
                    { 2, "3", new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3887), false, new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3885), null },
                    { 3, "3", new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3899), false, new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3897), null }
========
                    { 1, "4", new DateTime(2023, 1, 24, 17, 50, 43, 373, DateTimeKind.Local).AddTicks(5152), false, new DateTime(2023, 1, 24, 17, 50, 43, 373, DateTimeKind.Local).AddTicks(5009), null },
                    { 2, "4", new DateTime(2023, 1, 24, 17, 50, 43, 373, DateTimeKind.Local).AddTicks(5227), false, new DateTime(2023, 1, 24, 17, 50, 43, 373, DateTimeKind.Local).AddTicks(5224), null }
>>>>>>>> origin/MikaelHomeCodeMerge01:MVC_Webshop/Migrations/20230124165044_init.cs
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "ShortDescription" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVC_Webshop/Migrations/20230123151616_wwwwwwwww.cs
                    { 1, "Birdstuff", 1, "it's a type of bird", "/img/gerpgork.jpg", "Gerpgork", 2000.0, 1, "tb" },
                    { 2, "Chiquita", 2, "it's a type of Banana", "/img/Banana.jpg", "Banana", 5.0, 1, "tb" },
                    { 3, "Volvo", 3, "it's a type of car", "/img/Volvo.jpg", "Volvo XC70", 500000.0, 1, "tb" }
========
                    { 1, "Frukt & Grönt", 0, "Dessa mangosar är plockade av elitpersonal djupt nere i den farliga mangodalen.", "/imagesProduct/8fa4535c-a692-4407-83f6-e74e4dcd903b_mango-01.jpg", "Mango", 5.0, 200, "Fina mango från Mangodalen" },
                    { 2, "Sura Gubben", 0, "Dessa citroner som odlas på hemlig utomjordisk plats har den finaste och söta surhet som någonsin uppmätts i en citron.", "/imagesProduct/3aeac812-a431-4711-83b3-079816d8a7c1_lemon-01.jpg", "Citron", 4.7999999999999998, 800, "Färska och sura citroner" },
                    { 3, "Äppelmannen & Co", 0, "Dessa härliga äpplen är odlade av äppelmannen i hans trädgård. De är friska och alltid färska. Dessa bör man passa på att köpa när de finns eftersom de är svåra att få tag i när de inte finns.", "/imagesProduct/c8894c3b-9e69-4a34-97fd-3296ad428e49_apple-02.jpg", "Gröna äpplen", 6.0, 140, "Snabba äpplen med frisk smak" },
                    { 4, "Mr Blueberry", 0, "Dessa bär smakar bäst efter att man mosat en näve bär i handen och sen slickar rent fingrarna..", "/imagesProduct/4b518a1f-27a4-4ad6-8996-ce900469135b_blueberry-01.jpg", "Blåbär", 0.040000000000000001, 1000000, "Små runda blåa blåbär" }
>>>>>>>> origin/MikaelHomeCodeMerge01:MVC_Webshop/Migrations/20230124165044_init.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVC_Webshop/Migrations/20230123151616_wwwwwwwww.cs
                    { "17e89352-86f8-4138-8352-03640369af8f", 0, null, 3, null, "55e67838-302e-4b71-ace4-a17b7aa4dc77", null, "123", "random@user.com", false, "Joe", "Sixpack", false, null, "RANDOM@USER.COM", "JOE", 3, "AQAAAAEAACcQAAAAEJeysC3SlYITR9pcvkuV8Wk9pUups3Ibm+0yZ1Qw8O5JIxudOJoxoqquvNB2BlhV4Q==", null, false, null, null, "a3dfe5ee-81fe-4ba2-aa73-9944501ca744", false, "Joe" },
                    { "6c754753-efe8-49c9-9988-fb46165b6a6b", 0, null, 1, null, "bcc35a65-e11a-4a75-9f23-4da61ea8d9b0", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEDhlKP7cMWeaX/Taqb+NKE4q99gjIOxqjilvdGo7Z+JpEyhp9Jh+TF6chvQVozjtsQ==", null, false, null, null, "5d73cd17-557c-43e7-8b6a-3587256fe7c3", false, "Admin" },
                    { "f5e1eb4f-6079-4b17-88a9-0b35e22a2685", 0, null, 2, null, "3f5fca7e-d50d-4f9b-9bf8-a6792ef35fcc", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEPzzE5NI7/R5K/M1g62nvgen8/Pn86n2SWb5RwZmRM9yjWEsX3FUaEYcahgs5oZ6/Q==", null, false, null, null, "d62efd82-f5f4-47c0-86d1-6dcb30c1c5cf", false, "Karen" }
========
                    { "53db8c92-a481-4464-95e0-d93fb45c8195", 0, null, 2, null, "bcd87f8e-b3c6-41b8-929c-19e420450647", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEB4eJ11usKcODZusRgz5SjEoKqJL2jBPfyIdfW3EZXvbWX9/yu9uzh8MQP+vTS8JaA==", null, false, null, "3d631e31-9153-4c31-90f0-8e967e1e7414", false, "Karen" },
                    { "a2534b98-d03e-4de0-bb0f-f00a9772ddbc", 0, null, 1, null, "773328d7-934e-4122-b66f-479333edbc81", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEI+yR6jDY5arFhXEz2wDgSbznkEJ1Mx93QDmdjrByP/D7JPyxxVVAaGHZw3shRRg0w==", null, false, null, "305adce2-7f15-4df2-97f8-df3b61976bdb", false, "Admin" }
>>>>>>>> origin/MikaelHomeCodeMerge01:MVC_Webshop/Migrations/20230124165044_init.cs
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CartId", "ProductIdRef", "Quantity" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:MVC_Webshop/Migrations/20230123151616_wwwwwwwww.cs
                values: new object[] { "17e89352-86f8-4138-8352-03640369af8f", "17e89352-86f8-4138-8352-03640369af8f" });
========
                values: new object[] { "53db8c92-a481-4464-95e0-d93fb45c8195", "a2534b98-d03e-4de0-bb0f-f00a9772ddbc" });
>>>>>>>> origin/MikaelHomeCodeMerge01:MVC_Webshop/Migrations/20230124165044_init.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:MVC_Webshop/Migrations/20230123151616_wwwwwwwww.cs
                values: new object[] { "6c754753-efe8-49c9-9988-fb46165b6a6b", "17e89352-86f8-4138-8352-03640369af8f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f5e1eb4f-6079-4b17-88a9-0b35e22a2685", "17e89352-86f8-4138-8352-03640369af8f" });
========
                values: new object[] { "b59e4b4b-a157-41a6-b6d9-abc84834529f", "a2534b98-d03e-4de0-bb0f-f00a9772ddbc" });
>>>>>>>> origin/MikaelHomeCodeMerge01:MVC_Webshop/Migrations/20230124165044_init.cs

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers",
                column: "CartId",
                unique: true,
                filter: "[CartId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CartId",
                table: "Items",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryCreateViewModel");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
