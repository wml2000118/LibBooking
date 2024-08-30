using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class FirstCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f7df8f-3164-4073-b829-a6f3ac69e2c8", "1f09cb59-7d85-4c8a-81b1-aac2a0d878b1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62f7df8f-3164-4073-b829-a6f3ac69e2c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f09cb59-7d85-4c8a-81b1-aac2a0d878b1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40fea7f7-84b8-4958-9431-f56d3ef0438c", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d828d312-d6a5-4803-b830-fb5eded65dc8", 0, "379c1abc-5713-4131-aa6a-8ffe4f7d1e3f", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEJET4gc8QxIV4t/1G6xq3J3/1RHsfBmBhHWUWIcTgph3Aw5hGMz9GTH4c/iGYFbvxg==", null, false, "03fe61ad-aa50-4a24-a2d7-7c104e8ecc4e", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "40fea7f7-84b8-4958-9431-f56d3ef0438c", "d828d312-d6a5-4803-b830-fb5eded65dc8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40fea7f7-84b8-4958-9431-f56d3ef0438c", "d828d312-d6a5-4803-b830-fb5eded65dc8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40fea7f7-84b8-4958-9431-f56d3ef0438c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d828d312-d6a5-4803-b830-fb5eded65dc8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62f7df8f-3164-4073-b829-a6f3ac69e2c8", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1f09cb59-7d85-4c8a-81b1-aac2a0d878b1", 0, "0330bc09-89a6-4e66-9282-37cbf683b760", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAENGyCa4ussWTQPST/dXPcgghfoflCl4QfuMbITQJ2PZRKSJgBtV9p3F3RYm3hUF4uw==", null, false, "fece17bf-cfb3-4adb-ba64-b803f27f3a9a", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "62f7df8f-3164-4073-b829-a6f3ac69e2c8", "1f09cb59-7d85-4c8a-81b1-aac2a0d878b1" });
        }
    }
}
