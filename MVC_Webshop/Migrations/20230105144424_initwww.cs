using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class initwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01253446-bffa-46cc-af6d-526622844cd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf47c57-3b38-480c-9c37-01c43f79379f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ea86235-d4a8-4f02-ba3d-d2eb0357725c", "01253446-bffa-46cc-af6d-526622844cd3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ea86235-d4a8-4f02-ba3d-d2eb0357725c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01253446-bffa-46cc-af6d-526622844cd3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0009ba45-733f-49a8-9c95-efe1cfcf533b", "502d6820-a5aa-43a0-a301-7c532112ec5e", "User", "USER" },
                    { "09d5fb32-707b-4731-bf27-41450a52df13", "e8fd1fc4-b443-4081-a046-68e3900b7a19", "Admin", "ADMIN" },
                    { "158365d4-7a7a-430a-ad83-3bca4375ec24", "c4559bd8-f0b4-4410-bc7a-6a0dd60ef571", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "ShipmentId", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0009ba45-733f-49a8-9c95-efe1cfcf533b", 0, null, null, "c8e45e48-b891-45f0-bb2f-42d156cab821", null, "zigiplz", "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", 0, "AQAAAAEAACcQAAAAEIESMEUzdrK4RQn6ttQ8kXUWEecMteKIDOEzzDWay9zSWe+SHGhm2V8pcjP22LOYLw==", null, false, null, 0, "05b8218b-a4ca-4d5e-87cb-c6b422a0dbe8", 0, 0, false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09d5fb32-707b-4731-bf27-41450a52df13", "0009ba45-733f-49a8-9c95-efe1cfcf533b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0009ba45-733f-49a8-9c95-efe1cfcf533b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "158365d4-7a7a-430a-ad83-3bca4375ec24");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09d5fb32-707b-4731-bf27-41450a52df13", "0009ba45-733f-49a8-9c95-efe1cfcf533b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09d5fb32-707b-4731-bf27-41450a52df13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0009ba45-733f-49a8-9c95-efe1cfcf533b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01253446-bffa-46cc-af6d-526622844cd3", "5c4b107f-2a95-47d7-ab21-0d4349c3b8de", "User", "USER" },
                    { "3cf47c57-3b38-480c-9c37-01c43f79379f", "90d26a1b-d92a-4279-b4b5-c9d5b6f1431c", "Manager", "MANAGER" },
                    { "9ea86235-d4a8-4f02-ba3d-d2eb0357725c", "1e8666b0-9057-42a9-a544-617a5e4c9879", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RoleId", "SecurityStamp", "ShipmentId", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "01253446-bffa-46cc-af6d-526622844cd3", 0, null, null, "1101d2e0-1bd9-46ef-a46d-956060f633cb", null, null, "admin@admin.com", false, "Admin", "Adminson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", 0, "AQAAAAEAACcQAAAAELgLxCTb3Ksvg+eyYYMUNzpjlTy12Oz0IEJdamQNURFZEO0qELUqOyOlOqklH5XDOA==", null, false, null, 0, "d39c692a-0b45-4e9d-8c33-3d5c536a1ac1", 0, 0, false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ea86235-d4a8-4f02-ba3d-d2eb0357725c", "01253446-bffa-46cc-af6d-526622844cd3" });
        }
    }
}
