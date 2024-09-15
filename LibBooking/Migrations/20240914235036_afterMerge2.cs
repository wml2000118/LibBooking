using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class afterMerge2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "be7fc195-4523-4c23-b36c-5b1a30cfda15", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "67afef06-6c35-4ce2-8703-dc447c0e8552", 0, "5312d5f2-9f73-4a4f-8691-c1956e900b52", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEBzJBhFsNgRQZR1HQ0yZhA6NkMDd0W5wPhXhN/TMpJo81yFTrLy3AsFYVa0M+3quBQ==", null, false, "a0b81ea1-9486-493a-abd3-8e25c78c1f37", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be7fc195-4523-4c23-b36c-5b1a30cfda15", "67afef06-6c35-4ce2-8703-dc447c0e8552" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be7fc195-4523-4c23-b36c-5b1a30cfda15", "67afef06-6c35-4ce2-8703-dc447c0e8552" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be7fc195-4523-4c23-b36c-5b1a30cfda15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67afef06-6c35-4ce2-8703-dc447c0e8552");

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
    }
}
