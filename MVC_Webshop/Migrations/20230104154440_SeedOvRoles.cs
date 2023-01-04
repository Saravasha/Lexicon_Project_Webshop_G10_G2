using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Webshop.Migrations
{
    public partial class SeedOvRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2162819b-d6b6-476f-bfbc-eb9c9b3c9a2a", "2d677adf-fb30-4fbd-af77-a03aeaa5b16e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65e6fd47-7a7d-497b-91e2-ab8be765ab13", "3242aac9-3bf2-4cf4-a270-d454e4fd4a88", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f77e1cd-f71f-46d1-952a-5bbfca58d850", "033445c6-13a1-4950-b6ad-da64e84c2209", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2162819b-d6b6-476f-bfbc-eb9c9b3c9a2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65e6fd47-7a7d-497b-91e2-ab8be765ab13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f77e1cd-f71f-46d1-952a-5bbfca58d850");
        }
    }
}
