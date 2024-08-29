using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class IdeaPad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4aae7cb3-09ea-4193-95de-76b87950d171", "fd869dd3-0dab-4750-8f5d-afe2add6bcb7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aae7cb3-09ea-4193-95de-76b87950d171");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd869dd3-0dab-4750-8f5d-afe2add6bcb7");

            migrationBuilder.DropColumn(
                name: "Enquiry",
                table: "LibrarianAppointments");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Enquiry",
                table: "LibrarianAppointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4aae7cb3-09ea-4193-95de-76b87950d171", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd869dd3-0dab-4750-8f5d-afe2add6bcb7", 0, "9218142e-1110-4de4-b724-c4262eb03635", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEEY/4LEWWFXgFkohJQPMc2QMvYd+A6LnEqRVKy9lnsxoj2CaJ2RGHnT44yOou8wYIQ==", null, false, "f907ea69-28eb-4576-b96e-cc73ec49e6ed", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4aae7cb3-09ea-4193-95de-76b87950d171", "fd869dd3-0dab-4750-8f5d-afe2add6bcb7" });
        }
    }
}
