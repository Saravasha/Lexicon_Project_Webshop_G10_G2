using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class imageurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acffbb4c-e538-4f7c-82a0-a13dc751e6cb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3064c70-d882-426c-b95f-c8d37ecf893f", "acffbb4c-e538-4f7c-82a0-a13dc751e6cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2d48c5b-5bbc-40aa-aa75-19134f38b682", "acffbb4c-e538-4f7c-82a0-a13dc751e6cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2d48c5b-5bbc-40aa-aa75-19134f38b682");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3064c70-d882-426c-b95f-c8d37ecf893f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2d48c5b-5bbc-40aa-aa75-19134f38b682");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acffbb4c-e538-4f7c-82a0-a13dc751e6cb");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "acffbb4c-e538-4f7c-82a0-a13dc751e6cb", "3ecda72d-3f08-4650-a7a3-3b3d5ccb9dce", "User", "USER" },
                    { "c3064c70-d882-426c-b95f-c8d37ecf893f", "feba3923-5a08-4511-8198-dd1785c7819c", "Admin", "ADMIN" },
                    { "e2d48c5b-5bbc-40aa-aa75-19134f38b682", "5f59fe66-00ce-441a-9beb-f77afc951f8f", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "acffbb4c-e538-4f7c-82a0-a13dc751e6cb", 0, null, 1, null, "d5f3b771-2a2c-4bf9-9c03-52f4a533efc4", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEK07F4Q5LCzK51mhkA5vGJRRu+zpSFkJZXryDhQs60N4fYvMdwiBUiEuWY4s27ZiLw==", null, false, null, "9103a88d-ab90-400b-a61b-7ece4a797574", false, "Admin" },
                    { "e2d48c5b-5bbc-40aa-aa75-19134f38b682", 0, null, 2, null, "8932d0ca-db2a-41c8-8035-737e6537ffee", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEBPw8mOaWRO08t0GBJ+C0Hk4idgIWon9uOeO77R3Hx/Vpqyqu/QFB9V3BRxiS5l9Ng==", null, false, null, "84c217b6-00f6-46f0-8a95-063a547e0e3b", false, "Karen" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "2", new DateTime(2023, 1, 11, 16, 1, 14, 538, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 1, 11, 16, 1, 14, 538, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "2", new DateTime(2023, 1, 11, 16, 1, 14, 538, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 1, 11, 16, 1, 14, 538, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c3064c70-d882-426c-b95f-c8d37ecf893f", "acffbb4c-e538-4f7c-82a0-a13dc751e6cb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2d48c5b-5bbc-40aa-aa75-19134f38b682", "acffbb4c-e538-4f7c-82a0-a13dc751e6cb" });
        }
    }
}
