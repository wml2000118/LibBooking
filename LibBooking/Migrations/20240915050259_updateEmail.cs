using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class updateEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f3cdafc-c491-4034-a034-a464124a5dfb", "68ed1ac7-4d5a-43a5-956a-3a3e0a2ee639" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f3cdafc-c491-4034-a034-a464124a5dfb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68ed1ac7-4d5a-43a5-956a-3a3e0a2ee639");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d26d411-41bd-4365-8d65-217b68d1f319", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a214c9d9-2348-4c93-b49d-e56ea8d55f2f", 0, "474dfc33-0085-477a-acb1-9d3bd16fbd05", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEMpv5df2XQNbz7xjyuC/sZNWEqYV8LK8awtm/YywsheGQU4xLYc094S8mF/xZsluMA==", null, false, "6ce1df87-9e95-4d1d-bbc2-fe1bc6d1c0a1", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d26d411-41bd-4365-8d65-217b68d1f319", "a214c9d9-2348-4c93-b49d-e56ea8d55f2f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d26d411-41bd-4365-8d65-217b68d1f319", "a214c9d9-2348-4c93-b49d-e56ea8d55f2f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d26d411-41bd-4365-8d65-217b68d1f319");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a214c9d9-2348-4c93-b49d-e56ea8d55f2f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f3cdafc-c491-4034-a034-a464124a5dfb", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68ed1ac7-4d5a-43a5-956a-3a3e0a2ee639", 0, "0b6d8608-7d8d-41e7-bb1b-ac52893f9049", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEPt5qLfcfanDXqWzk6LPAz165JTM8/QmIry+R6U80hnJ+ffbcUBoxaAH0CYRG0hX5A==", null, false, "12ef8ce9-0767-4cd4-9f6a-031e9d8ddf72", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f3cdafc-c491-4034-a034-a464124a5dfb", "68ed1ac7-4d5a-43a5-956a-3a3e0a2ee639" });
        }
    }
}
