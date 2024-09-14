using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class afterMerge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac74f3f3-822a-4d55-a11c-41b7d245fd1a", "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac74f3f3-822a-4d55-a11c-41b7d245fd1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a290c1f-3b05-4d3b-bced-da7e5b3e1435", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fee65838-7145-42d7-9118-4b1df5f00492", 0, "a72df499-4a30-48a3-95cc-6ccb22d68aa5", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEF/I4qFSoyXYxg03ngU+hdNopw3XQk+/+Ochc+d8ra1AmbonS0qwlTNnlEM7ZuLq0w==", null, false, "7ff72d30-9f23-4d44-a48c-1df45f910a8b", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a290c1f-3b05-4d3b-bced-da7e5b3e1435", "fee65838-7145-42d7-9118-4b1df5f00492" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a290c1f-3b05-4d3b-bced-da7e5b3e1435", "fee65838-7145-42d7-9118-4b1df5f00492" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a290c1f-3b05-4d3b-bced-da7e5b3e1435");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fee65838-7145-42d7-9118-4b1df5f00492");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac74f3f3-822a-4d55-a11c-41b7d245fd1a", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d", 0, "7e7d94ae-f88b-4d91-a98c-0b87eb393cd9", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEP1a7TvQD2BsaxoCjZ0wwOctzIQvFJBK0+Mh00zGyf/xKKDI6IfchSRWZFea/gCltg==", null, false, "73faa417-f7fc-40d7-b2a1-25feae11a316", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ac74f3f3-822a-4d55-a11c-41b7d245fd1a", "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d" });
        }
    }
}
