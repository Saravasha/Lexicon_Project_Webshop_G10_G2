using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class doopydoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_ApplicationUserViewModelUserId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ApplicationUserViewModelUserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccd47afc-fbef-4452-924c-9dbe2a559984");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a4dac990-d303-4dc3-859d-4faafe158a71", "ccd47afc-fbef-4452-924c-9dbe2a559984" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed4d9f96-be0b-47f5-86c5-347f1d0ec29f", "ccd47afc-fbef-4452-924c-9dbe2a559984" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4d9f96-be0b-47f5-86c5-347f1d0ec29f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4dac990-d303-4dc3-859d-4faafe158a71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed4d9f96-be0b-47f5-86c5-347f1d0ec29f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccd47afc-fbef-4452-924c-9dbe2a559984");

            migrationBuilder.DropColumn(
                name: "ApplicationUserViewModelUserId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19f83d4c-ef91-497d-8e95-508722483c14", "9025af65-5b24-4f41-8f63-69ada6a1b63f", "Admin", "ADMIN" },
                    { "f0cbff96-1c71-4b9d-a566-d83e3fab1868", "f4f7423b-9cef-4b6d-abef-84bcef4bfe91", "Manager", "MANAGER" },
                    { "f2e42a90-e464-4deb-b311-19db27300123", "02ea30eb-7665-4bdf-b3d4-ae40a7a019ca", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f0cbff96-1c71-4b9d-a566-d83e3fab1868", 0, null, 2, null, "4c051fe6-3f3c-4e0f-9a21-361692bd170e", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEFKmp+bDUVFLla45S9HnTgboG1AsGCaoTSGOEaiq3QlBJhe2ATnS8rxsc/HmVeMoCg==", null, false, null, null, "1e9ab178-5aa2-4d7c-a56c-39b75964b1e0", false, "Karen" },
                    { "f2e42a90-e464-4deb-b311-19db27300123", 0, null, 1, null, "9cabe29e-c069-4671-b3c9-655400513261", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEHLf7DEhhi/elmJkpGEsLOne0th9SO5AubZrrYrRW3jtyb6zKwK8Y9wOVsR/dVlKCQ==", null, false, null, null, "c82e3004-4853-4b5e-9745-2778e3759f1a", false, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "2", new DateTime(2023, 1, 20, 16, 14, 4, 868, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 1, 20, 16, 14, 4, 868, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "2", new DateTime(2023, 1, 20, 16, 14, 4, 868, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 1, 20, 16, 14, 4, 868, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "19f83d4c-ef91-497d-8e95-508722483c14", "f2e42a90-e464-4deb-b311-19db27300123" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f0cbff96-1c71-4b9d-a566-d83e3fab1868", "f2e42a90-e464-4deb-b311-19db27300123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2e42a90-e464-4deb-b311-19db27300123");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19f83d4c-ef91-497d-8e95-508722483c14", "f2e42a90-e464-4deb-b311-19db27300123" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0cbff96-1c71-4b9d-a566-d83e3fab1868", "f2e42a90-e464-4deb-b311-19db27300123" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0cbff96-1c71-4b9d-a566-d83e3fab1868");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19f83d4c-ef91-497d-8e95-508722483c14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0cbff96-1c71-4b9d-a566-d83e3fab1868");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2e42a90-e464-4deb-b311-19db27300123");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserViewModelUserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4dac990-d303-4dc3-859d-4faafe158a71", "0f51f9c7-fa21-4895-bb5a-7754cbe89c20", "Admin", "ADMIN" },
                    { "ccd47afc-fbef-4452-924c-9dbe2a559984", "257e7416-65e8-44d5-8471-dfc1c2246968", "User", "USER" },
                    { "ed4d9f96-be0b-47f5-86c5-347f1d0ec29f", "3e943200-c4fd-4d00-9d08-3aaa40622e3d", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ccd47afc-fbef-4452-924c-9dbe2a559984", 0, null, 1, null, "2b185c9c-6190-43e6-b7eb-db963bb929c3", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEBbUd33k/DhTloFSXZ6Pbu3t1UVmRDfFoOmtoxA1FGAxdBVZWYafXKbLIZFgKNvzqg==", null, false, null, null, "418e8403-d516-4d13-889e-f1adad2372d0", false, "Admin" },
                    { "ed4d9f96-be0b-47f5-86c5-347f1d0ec29f", 0, null, 2, null, "f29c4431-1e81-4a7e-b842-980259a5cf81", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEOkWK8NUkoguU/f2FDoQZxJcCyDbdLYMKJwgrjj/MMOPditmmc4TbcgJUhpxnqtwvw==", null, false, null, null, "a646e44e-4752-4091-9261-865c1dd7698d", false, "Karen" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "4", new DateTime(2023, 1, 17, 16, 14, 53, 275, DateTimeKind.Local).AddTicks(1183), new DateTime(2023, 1, 17, 16, 14, 53, 275, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "4", new DateTime(2023, 1, 17, 16, 14, 53, 275, DateTimeKind.Local).AddTicks(1200), new DateTime(2023, 1, 17, 16, 14, 53, 275, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a4dac990-d303-4dc3-859d-4faafe158a71", "ccd47afc-fbef-4452-924c-9dbe2a559984" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed4d9f96-be0b-47f5-86c5-347f1d0ec29f", "ccd47afc-fbef-4452-924c-9dbe2a559984" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserViewModelUserId",
                table: "Orders",
                column: "ApplicationUserViewModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CartId",
                table: "Users",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_ApplicationUserViewModelUserId",
                table: "Orders",
                column: "ApplicationUserViewModelUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
