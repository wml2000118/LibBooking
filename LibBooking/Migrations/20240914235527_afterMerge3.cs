using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class afterMerge3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
