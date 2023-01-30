using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class gerpgorkwwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f6134e6-27f2-44da-91bf-076960c4fc67", "5555ce94-f9f8-4d01-9707-f7a060ee1fcb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5555ce94-f9f8-4d01-9707-f7a060ee1fcb", "5555ce94-f9f8-4d01-9707-f7a060ee1fcb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cc0fd32-50e4-4f00-bf71-693166d38ebb", "5555ce94-f9f8-4d01-9707-f7a060ee1fcb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f6134e6-27f2-44da-91bf-076960c4fc67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cc0fd32-50e4-4f00-bf71-693166d38ebb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f6134e6-27f2-44da-91bf-076960c4fc67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5555ce94-f9f8-4d01-9707-f7a060ee1fcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cc0fd32-50e4-4f00-bf71-693166d38ebb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5555ce94-f9f8-4d01-9707-f7a060ee1fcb");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "528591c2-1746-45df-b543-32c9e358c032", "456e857d-6c06-466e-971e-192b8cad22e8", "Admin", "ADMIN" },
                    { "86078e4d-bc14-41f7-a883-17772b1edc92", "4de291ec-211d-46b8-a2db-b5d47450c214", "User", "USER" },
                    { "b9435db4-b9aa-464a-acd0-3aff22f7fb08", "4d4a09fc-b609-4176-8d6c-cec9348cf1f1", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "528591c2-1746-45df-b543-32c9e358c032", 0, null, 1, null, "8b2be594-e182-405f-a5be-02c7ca83717a", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", 1, "AQAAAAEAACcQAAAAEJEinBxv9RwSr6+etszOxq6/KL6NtgTKZ7awzmfs7YQmHiy/JtjDpM1QEWMgVtetGA==", null, false, null, null, "a817167b-84dc-408a-9ccd-cdbab958b6e2", false, null, "admin@admin.com" },
                    { "86078e4d-bc14-41f7-a883-17772b1edc92", 0, null, 3, null, "4d2fc456-6e2e-4f04-84cd-8f48ab5a56b7", null, "123", "random@user.com", false, "Joe", "Sixpack", false, null, "RANDOM@USER.COM", "RANDOM@USER.COM", 3, "AQAAAAEAACcQAAAAEAx/jQiK36FwNJfNtzxHVglMgpyz7XsPX9w1GBVY/0HUILMjaz+zU3Gyq01vfGYVvg==", null, false, null, null, "6f157957-e858-4ca3-b943-b984cc6a8563", false, null, "random@user.com" },
                    { "b9435db4-b9aa-464a-acd0-3aff22f7fb08", 0, null, 2, null, "c4331eaf-cfeb-435a-9bdf-51713f182c76", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN@MANAGER.COM", 2, "AQAAAAEAACcQAAAAEH14jTLQrFkaOEfBd7vgHIWK2TcNyOdAr1olH6+jnwQVyxTRGLA1TFNUsXBVKNqNBQ==", null, false, null, null, "f979ee40-d951-4903-88e7-59cbd48f3e64", false, null, "karen@manager.com" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 30, 14, 14, 49, 105, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 1, 30, 14, 14, 49, 105, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 30, 14, 14, 49, 105, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 1, 30, 14, 14, 49, 105, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 30, 14, 14, 49, 105, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 1, 30, 14, 14, 49, 105, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "528591c2-1746-45df-b543-32c9e358c032", "86078e4d-bc14-41f7-a883-17772b1edc92" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "86078e4d-bc14-41f7-a883-17772b1edc92", "86078e4d-bc14-41f7-a883-17772b1edc92" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b9435db4-b9aa-464a-acd0-3aff22f7fb08", "86078e4d-bc14-41f7-a883-17772b1edc92" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "528591c2-1746-45df-b543-32c9e358c032", "86078e4d-bc14-41f7-a883-17772b1edc92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86078e4d-bc14-41f7-a883-17772b1edc92", "86078e4d-bc14-41f7-a883-17772b1edc92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b9435db4-b9aa-464a-acd0-3aff22f7fb08", "86078e4d-bc14-41f7-a883-17772b1edc92" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "528591c2-1746-45df-b543-32c9e358c032");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9435db4-b9aa-464a-acd0-3aff22f7fb08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528591c2-1746-45df-b543-32c9e358c032");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86078e4d-bc14-41f7-a883-17772b1edc92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9435db4-b9aa-464a-acd0-3aff22f7fb08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86078e4d-bc14-41f7-a883-17772b1edc92");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f6134e6-27f2-44da-91bf-076960c4fc67", "556d7212-c21c-4ad1-af7b-22d49f08fc01", "Admin", "ADMIN" },
                    { "5555ce94-f9f8-4d01-9707-f7a060ee1fcb", "3cd5f5bf-b996-420f-a514-c9eb29b7010a", "User", "USER" },
                    { "6cc0fd32-50e4-4f00-bf71-693166d38ebb", "9652953d-551c-4cb4-86ca-bbe397aee0d7", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f6134e6-27f2-44da-91bf-076960c4fc67", 0, null, 1, null, "a4325426-ae5d-4e36-9b06-511c31fe2cd9", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", 1, "AQAAAAEAACcQAAAAEDtW1rdhZk26Cm8ijkEEj9fz6FIF2fX/xI4pVe/yr2Yz9BgTAOQa6RGqBIZRg5NZ5g==", null, false, null, null, "a1bfb4b3-ac9c-48dd-b176-98524281dea1", false, "admin@admin.com" },
                    { "5555ce94-f9f8-4d01-9707-f7a060ee1fcb", 0, null, 3, null, "1ca042e8-2cc0-43d8-ab62-ef0c042c7d06", null, "123", "random@user.com", false, "Joe", "Sixpack", false, null, "RANDOM@USER.COM", "RANDOM@USER.COM", 3, "AQAAAAEAACcQAAAAENDY8ewYQSgphipoZ7ds7eMuKzACrPMj3a8QNVEdG0ENc525ykaN5ndIWeJYWZ+qog==", null, false, null, null, "7e260933-766b-441a-bfad-f144bf6f994c", false, "random@user.com" },
                    { "6cc0fd32-50e4-4f00-bf71-693166d38ebb", 0, null, 2, null, "3d05a2e0-ed6e-4d29-bc89-4abcd397ec0e", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN@MANAGER.COM", 2, "AQAAAAEAACcQAAAAEFAQg2Dt9gFrL6rIHt4xe+u1aSvgHshlTUPM7uuVnYUe8M/qafhT7Xd+C9xNsLvV4g==", null, false, null, null, "50b51813-16f9-4666-ab3b-d16a3ca9b22a", false, "karen@manager.com" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "4", new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "4", new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "4", new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 1, 30, 12, 36, 32, 203, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3f6134e6-27f2-44da-91bf-076960c4fc67", "5555ce94-f9f8-4d01-9707-f7a060ee1fcb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5555ce94-f9f8-4d01-9707-f7a060ee1fcb", "5555ce94-f9f8-4d01-9707-f7a060ee1fcb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6cc0fd32-50e4-4f00-bf71-693166d38ebb", "5555ce94-f9f8-4d01-9707-f7a060ee1fcb" });
        }
    }
}
