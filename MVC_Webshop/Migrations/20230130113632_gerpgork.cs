using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class gerpgork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9546df1a-3cc1-44c4-bb7c-146ebefd0383", "cfaa22b5-f221-4f6d-a5df-50035540744f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cfaa22b5-f221-4f6d-a5df-50035540744f", "cfaa22b5-f221-4f6d-a5df-50035540744f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f47ff870-5af1-49df-adf7-a4564168e2b0", "cfaa22b5-f221-4f6d-a5df-50035540744f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9546df1a-3cc1-44c4-bb7c-146ebefd0383");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f47ff870-5af1-49df-adf7-a4564168e2b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9546df1a-3cc1-44c4-bb7c-146ebefd0383");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfaa22b5-f221-4f6d-a5df-50035540744f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f47ff870-5af1-49df-adf7-a4564168e2b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfaa22b5-f221-4f6d-a5df-50035540744f");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserViewModelUserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationUserViewModel",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserViewModel", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_ApplicationUserViewModel_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserViewModelUserId",
                table: "Orders",
                column: "ApplicationUserViewModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserViewModel_CartId",
                table: "ApplicationUserViewModel",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ApplicationUserViewModel_ApplicationUserViewModelUserId",
                table: "Orders",
                column: "ApplicationUserViewModelUserId",
                principalTable: "ApplicationUserViewModel",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ApplicationUserViewModel_ApplicationUserViewModelUserId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ApplicationUserViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ApplicationUserViewModelUserId",
                table: "Orders");

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

            migrationBuilder.DropColumn(
                name: "ApplicationUserViewModelUserId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9546df1a-3cc1-44c4-bb7c-146ebefd0383", "936602d0-b61b-4cb4-a44b-dfc1fe0f0697", "Manager", "MANAGER" },
                    { "cfaa22b5-f221-4f6d-a5df-50035540744f", "f22cb42a-3212-4660-b05f-9186ff4d1961", "User", "USER" },
                    { "f47ff870-5af1-49df-adf7-a4564168e2b0", "ff7eb4f7-0952-43d0-96e9-c63fb20c0f29", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9546df1a-3cc1-44c4-bb7c-146ebefd0383", 0, null, 2, null, "e547e9e5-6294-47c5-89fd-5ca073800212", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEGPh/HjWHMLwwJrxePKpeQNAJ8JuwkB1/wceDR5LCEEqTKR84AW36s7diTDOsqPjvA==", null, false, null, null, "aeae8fb6-5dd9-4cd4-a35a-b035071c26c5", false, "Karen" },
                    { "cfaa22b5-f221-4f6d-a5df-50035540744f", 0, null, 3, null, "4094bc7e-6cc9-47d1-b378-ad3ef2fac2b5", null, "123", "random@user.com", false, "Joe", "Sixpack", false, null, "RANDOM@USER.COM", "JOE", 3, "AQAAAAEAACcQAAAAEKCtpSslL8GuDHy+VAh//lz6AWzFXeyfY2J/UJHsQ1R6DHHNPPz/e+Ks48fitGG4DA==", null, false, null, null, "cc65f618-bd60-4f95-985e-3154e44f0aa8", false, "Joe" },
                    { "f47ff870-5af1-49df-adf7-a4564168e2b0", 0, null, 1, null, "09ae3001-729f-4581-a6b7-caec2a4064a5", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", 1, "AQAAAAEAACcQAAAAEMs5fpaGQV6tl3uoIWXMbtuXqthrdoCq7WOSUAS6dAlU0hslYc4XhCn3536rOivgNA==", null, false, null, null, "e45b85de-0b71-4935-b474-93b8ac3087c8", false, "admin@admin.com" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 30, 10, 6, 48, 672, DateTimeKind.Local).AddTicks(783), new DateTime(2023, 1, 30, 10, 6, 48, 672, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 30, 10, 6, 48, 672, DateTimeKind.Local).AddTicks(904), new DateTime(2023, 1, 30, 10, 6, 48, 672, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "1", new DateTime(2023, 1, 30, 10, 6, 48, 672, DateTimeKind.Local).AddTicks(920), new DateTime(2023, 1, 30, 10, 6, 48, 672, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9546df1a-3cc1-44c4-bb7c-146ebefd0383", "cfaa22b5-f221-4f6d-a5df-50035540744f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cfaa22b5-f221-4f6d-a5df-50035540744f", "cfaa22b5-f221-4f6d-a5df-50035540744f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f47ff870-5af1-49df-adf7-a4564168e2b0", "cfaa22b5-f221-4f6d-a5df-50035540744f" });
        }
    }
}
