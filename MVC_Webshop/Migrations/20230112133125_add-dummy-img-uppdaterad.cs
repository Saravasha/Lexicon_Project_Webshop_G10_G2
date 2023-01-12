using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class adddummyimguppdaterad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2135ed9f-69aa-423d-b8c0-72dbc38610b7", "43278256-04d5-4fd3-89ee-85e79865906f", "Manager", "MANAGER" },
                    { "3277b0f9-1901-4210-bcf3-edc3268d6691", "6766151a-aa78-45d1-ae6f-d46856b6dedf", "Admin", "ADMIN" },
                    { "d8fe1bbb-d128-4b02-a034-bb2c043352d0", "bc5fee56-c704-40d7-97e5-f2ee63cc578b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2135ed9f-69aa-423d-b8c0-72dbc38610b7", 0, null, 2, null, "869d71dc-2ba8-4450-9e4b-b3a8707acf42", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEDaBQyAxQHmYIDhNqxZIkSVrdTWj3iJWeRhkluQo2r+hkEgM4uvOU64gx9K917j/6w==", null, false, null, "959521c7-19f0-4183-b5ad-1918e9fbd2a6", false, "Karen" },
                    { "d8fe1bbb-d128-4b02-a034-bb2c043352d0", 0, null, 1, null, "323f20c2-01f2-4b76-95f6-fedde831a087", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEGtY6YnHphNCAx9jCzHlrlGjOAYKbRycJ6wc9/2ImFRNDfFzpxkzH54UZexdlc0Bjg==", null, false, null, "e6bd20eb-a458-48c4-b6af-b20a1afa7741", false, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderDate", "ShippingDate" },
                values: new object[] { new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "ShippingDate" },
                values: new object[] { new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 1, 12, 14, 31, 24, 427, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/img/bird.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/img/banana.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/img/volvo.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2135ed9f-69aa-423d-b8c0-72dbc38610b7", "d8fe1bbb-d128-4b02-a034-bb2c043352d0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3277b0f9-1901-4210-bcf3-edc3268d6691", "d8fe1bbb-d128-4b02-a034-bb2c043352d0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8fe1bbb-d128-4b02-a034-bb2c043352d0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2135ed9f-69aa-423d-b8c0-72dbc38610b7", "d8fe1bbb-d128-4b02-a034-bb2c043352d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3277b0f9-1901-4210-bcf3-edc3268d6691", "d8fe1bbb-d128-4b02-a034-bb2c043352d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2135ed9f-69aa-423d-b8c0-72dbc38610b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2135ed9f-69aa-423d-b8c0-72dbc38610b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3277b0f9-1901-4210-bcf3-edc3268d6691");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8fe1bbb-d128-4b02-a034-bb2c043352d0");

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
                columns: new[] { "OrderDate", "ShippingDate" },
                values: new object[] { new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "ShippingDate" },
                values: new object[] { new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 1, 12, 14, 27, 19, 59, DateTimeKind.Local).AddTicks(1045) });

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
    }
}
