using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserIDFromLibrarianAppointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4acc9930-ce19-45c5-b4dc-6d71a494af37", "45115396-95f2-46e0-8e58-ad39e325db2c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4acc9930-ce19-45c5-b4dc-6d71a494af37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45115396-95f2-46e0-8e58-ad39e325db2c");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "LibrarianAppointments");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "LibrarianAppointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4acc9930-ce19-45c5-b4dc-6d71a494af37", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "45115396-95f2-46e0-8e58-ad39e325db2c", 0, "c169cbf1-22f1-49d3-bee7-35a439d35084", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAED+BWvamhsH9WqAW1907UtSM8SiDQ2PwmpqmlHprYOTN7JNVnoM6GWKoKB5GBu3kog==", null, false, "ac71a97f-ccfd-4704-83de-23a42abbddf7", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4acc9930-ce19-45c5-b4dc-6d71a494af37", "45115396-95f2-46e0-8e58-ad39e325db2c" });
        }
    }
}
