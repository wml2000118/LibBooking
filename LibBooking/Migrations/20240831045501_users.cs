using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4c31d7e7-7de8-454d-90d5-70ba1b4c070d", 0, "c3a63220-cf9a-48e8-ad05-3e8263082c33", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEMKbBqftJhM2mR8VX+UPswz7al1DwwMCEEwHXaXF7A3/Ekfww6TH931I9Aet+mvrow==", null, false, "cd2de34f-176a-4e2e-ac41-09ef9056decf", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c", "4c31d7e7-7de8-454d-90d5-70ba1b4c070d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c", "4c31d7e7-7de8-454d-90d5-70ba1b4c070d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c31d7e7-7de8-454d-90d5-70ba1b4c070d");

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
    }
}
