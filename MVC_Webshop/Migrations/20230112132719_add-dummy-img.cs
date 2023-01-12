using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class adddummyimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bb93f82-1ef9-4b21-b803-0e7180eb703f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8886c640-8bee-4820-9d24-a785289b97e0", "1bb93f82-1ef9-4b21-b803-0e7180eb703f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4d3509d-8bdf-4aa4-b255-18df53af4711", "1bb93f82-1ef9-4b21-b803-0e7180eb703f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8886c640-8bee-4820-9d24-a785289b97e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8886c640-8bee-4820-9d24-a785289b97e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4d3509d-8bdf-4aa4-b255-18df53af4711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bb93f82-1ef9-4b21-b803-0e7180eb703f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67c61137-17f8-4652-a4cf-3b8cb691524e", "78979da4-5ea4-4e51-8345-df666eea2921", "User", "USER" },
                    { "8cb528a1-0870-435c-a783-397fd662ab11", "99a4731a-7566-4ac7-8b9c-9b959a7cfb29", "Admin", "ADMIN" },
                    { "c805e25d-54b2-4c6c-99bc-f1effdb29802", "de1bafbc-628b-433b-8d97-d7ded375b5b2", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "67c61137-17f8-4652-a4cf-3b8cb691524e", 0, null, 1, null, "24ab7800-5fb3-4f08-aed7-046a624dbe44", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEIZEUHwjhqG/FB4YEFe8Rl+u6OxhVf3C07SDXn6hau1hZoAwyiM9Wm8Cyumn8GYOuA==", null, false, null, "4b9640dd-5ebb-4bf0-9f57-baeb18c8da24", false, "Admin" },
                    { "c805e25d-54b2-4c6c-99bc-f1effdb29802", 0, null, 2, null, "da323145-83e5-4dd4-a2e3-0592f6c43bcf", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAECQpMENffLMnlm+pa7URFI6pIh3r1j7NcNnIfYtMUhakx9Sbt7T6DS+MiOdz1EEvJg==", null, false, null, "a3223f94-18db-428e-96e6-8d8fc2f1131d", false, "Karen" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "4", new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "4", new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/img/bird.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/img/banana.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/img/volvo.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8cb528a1-0870-435c-a783-397fd662ab11", "67c61137-17f8-4652-a4cf-3b8cb691524e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c805e25d-54b2-4c6c-99bc-f1effdb29802", "67c61137-17f8-4652-a4cf-3b8cb691524e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67c61137-17f8-4652-a4cf-3b8cb691524e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8cb528a1-0870-435c-a783-397fd662ab11", "67c61137-17f8-4652-a4cf-3b8cb691524e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c805e25d-54b2-4c6c-99bc-f1effdb29802", "67c61137-17f8-4652-a4cf-3b8cb691524e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c805e25d-54b2-4c6c-99bc-f1effdb29802");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cb528a1-0870-435c-a783-397fd662ab11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c805e25d-54b2-4c6c-99bc-f1effdb29802");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67c61137-17f8-4652-a4cf-3b8cb691524e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1bb93f82-1ef9-4b21-b803-0e7180eb703f", "5b6b080c-ee4c-4b06-b59b-dbde20116e56", "User", "USER" },
                    { "8886c640-8bee-4820-9d24-a785289b97e0", "aea58782-ff5e-43b6-9410-d63321f75555", "Manager", "MANAGER" },
                    { "e4d3509d-8bdf-4aa4-b255-18df53af4711", "cdf36368-c3ff-450c-b7ab-7c2edce0ada4", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1bb93f82-1ef9-4b21-b803-0e7180eb703f", 0, null, 1, null, "6e6a7ecd-e1e3-4513-86f3-aa8e4b84716f", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEFSJjsrZ3RohIyABlQnjBwRRjoFvG7g2fKoOSqF1dv4hZY7wNhYOoLkYLQM+6XT0sw==", null, false, null, "3b96e2e9-4a72-4495-b82f-1f4b2796c2ed", false, "Admin" },
                    { "8886c640-8bee-4820-9d24-a785289b97e0", 0, null, 2, null, "96ce24d2-b797-4032-92a5-cb91f9444147", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEN5OhQ9Z1CsMUqcVP/vUSo2/sY6IwqHuY7Hhb43HvuBNEc1EqBFDePiLZP4G1TJE1w==", null, false, null, "f35fae91-0aa3-4a59-bb5e-24bcb88011eb", false, "Karen" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 12, 11, 33, 52, 345, DateTimeKind.Local).AddTicks(1633), new DateTime(2023, 1, 12, 11, 33, 52, 345, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 12, 11, 33, 52, 345, DateTimeKind.Local).AddTicks(1654), new DateTime(2023, 1, 12, 11, 33, 52, 345, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8886c640-8bee-4820-9d24-a785289b97e0", "1bb93f82-1ef9-4b21-b803-0e7180eb703f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4d3509d-8bdf-4aa4-b255-18df53af4711", "1bb93f82-1ef9-4b21-b803-0e7180eb703f" });
        }
    }
}
