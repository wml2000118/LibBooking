using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class firstcommit4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b3532e3-53d4-40d9-a034-590b8b824a87", "15f4020a-2ccd-4416-9d32-f1e32a728418" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b3532e3-53d4-40d9-a034-590b8b824a87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15f4020a-2ccd-4416-9d32-f1e32a728418");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a764762-6c52-4070-9a01-d7429c406891", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "05ef65c5-4f9f-4a4a-8436-04934e3344cd", 0, "023ae6ce-0ab8-4053-b5dc-659de0673af7", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEE4qy8wI01pm7XeubfX1Y8a+sOH7dKNGi/A7gwFx3R1EEIGbkIG8KqJ2Ba1ndkKtWA==", null, false, "1bc44898-c159-4a8b-8e15-3d43ad39253b", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a764762-6c52-4070-9a01-d7429c406891", "05ef65c5-4f9f-4a4a-8436-04934e3344cd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a764762-6c52-4070-9a01-d7429c406891", "05ef65c5-4f9f-4a4a-8436-04934e3344cd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a764762-6c52-4070-9a01-d7429c406891");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05ef65c5-4f9f-4a4a-8436-04934e3344cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b3532e3-53d4-40d9-a034-590b8b824a87", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "15f4020a-2ccd-4416-9d32-f1e32a728418", 0, "b58abf2c-6a6a-4f3c-a332-f08dcef6dbdb", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAENumqt4jQkAdzuegnkb/+P7sU0wEIqceR8QbEssNuenrrOhn2sLODjRdhtIduG6qtA==", null, false, "32b06e29-9fd1-410d-93c5-97df67f8f167", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4b3532e3-53d4-40d9-a034-590b8b824a87", "15f4020a-2ccd-4416-9d32-f1e32a728418" });
        }
    }
}
