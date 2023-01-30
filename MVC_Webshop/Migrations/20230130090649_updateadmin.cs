using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class updateadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17e89352-86f8-4138-8352-03640369af8f", "17e89352-86f8-4138-8352-03640369af8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c754753-efe8-49c9-9988-fb46165b6a6b", "17e89352-86f8-4138-8352-03640369af8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f5e1eb4f-6079-4b17-88a9-0b35e22a2685", "17e89352-86f8-4138-8352-03640369af8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c754753-efe8-49c9-9988-fb46165b6a6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5e1eb4f-6079-4b17-88a9-0b35e22a2685");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17e89352-86f8-4138-8352-03640369af8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c754753-efe8-49c9-9988-fb46165b6a6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5e1eb4f-6079-4b17-88a9-0b35e22a2685");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e89352-86f8-4138-8352-03640369af8f");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17e89352-86f8-4138-8352-03640369af8f", "74da152f-a44d-497a-b985-cc733558f97b", "User", "USER" },
                    { "6c754753-efe8-49c9-9988-fb46165b6a6b", "5c88a13c-bd41-4915-b3a2-5dda9a78b236", "Admin", "ADMIN" },
                    { "f5e1eb4f-6079-4b17-88a9-0b35e22a2685", "94c4860f-eb84-42ac-bbff-850a71ebda8e", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17e89352-86f8-4138-8352-03640369af8f", 0, null, 3, null, "55e67838-302e-4b71-ace4-a17b7aa4dc77", null, "123", "random@user.com", false, "Joe", "Sixpack", false, null, "RANDOM@USER.COM", "JOE", 3, "AQAAAAEAACcQAAAAEJeysC3SlYITR9pcvkuV8Wk9pUups3Ibm+0yZ1Qw8O5JIxudOJoxoqquvNB2BlhV4Q==", null, false, null, null, "a3dfe5ee-81fe-4ba2-aa73-9944501ca744", false, "Joe" },
                    { "6c754753-efe8-49c9-9988-fb46165b6a6b", 0, null, 1, null, "bcc35a65-e11a-4a75-9f23-4da61ea8d9b0", null, "234", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEDhlKP7cMWeaX/Taqb+NKE4q99gjIOxqjilvdGo7Z+JpEyhp9Jh+TF6chvQVozjtsQ==", null, false, null, null, "5d73cd17-557c-43e7-8b6a-3587256fe7c3", false, "Admin" },
                    { "f5e1eb4f-6079-4b17-88a9-0b35e22a2685", 0, null, 2, null, "3f5fca7e-d50d-4f9b-9bf8-a6792ef35fcc", null, "123", "karen@manager.com", false, "Karen", "Managerson", false, null, "KAREN@MANAGER.COM", "KAREN", 2, "AQAAAAEAACcQAAAAEPzzE5NI7/R5K/M1g62nvgen8/Pn86n2SWb5RwZmRM9yjWEsX3FUaEYcahgs5oZ6/Q==", null, false, null, null, "d62efd82-f5f4-47c0-86d1-6dcb30c1c5cf", false, "Karen" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "3", new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "3", new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3887), new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpectedDelivery", "OrderDate", "ShippingDate" },
                values: new object[] { "3", new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3899), new DateTime(2023, 1, 23, 16, 16, 15, 723, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "17e89352-86f8-4138-8352-03640369af8f", "17e89352-86f8-4138-8352-03640369af8f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6c754753-efe8-49c9-9988-fb46165b6a6b", "17e89352-86f8-4138-8352-03640369af8f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f5e1eb4f-6079-4b17-88a9-0b35e22a2685", "17e89352-86f8-4138-8352-03640369af8f" });
        }
    }
}
