using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class firstcommit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5c9ad288-9b2e-4fea-a750-e1573cab0e75", "a8acfc43-1fc0-4552-b789-4ac8e9252c82" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c9ad288-9b2e-4fea-a750-e1573cab0e75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8acfc43-1fc0-4552-b789-4ac8e9252c82");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5c9ad288-9b2e-4fea-a750-e1573cab0e75", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a8acfc43-1fc0-4552-b789-4ac8e9252c82", 0, "19d32d2c-6d55-4beb-9b67-27c90e7829bd", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEHHCI5KkemSlHdaAW42AC2lrYmEVQr5mvb0rX0KkrbbhLihVOCClIPYs6dcEAkCkgQ==", null, false, "5553b983-a8fe-41fd-92e7-b7ec0202da0c", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5c9ad288-9b2e-4fea-a750-e1573cab0e75", "a8acfc43-1fc0-4552-b789-4ac8e9252c82" });
        }
    }
}
