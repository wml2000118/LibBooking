using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class firstcommit5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d8949af0-a173-4241-9706-e3bf205b5817", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0ccf2492-b644-43c5-93ec-637d63b98ca0", 0, "b7ed9b78-a171-4eb1-91b2-01f441d24cbb", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEFPcOqpJjCYYuUPIwE2jI+Pq3PunIB45SvPrlZM0uX5kxH9JQGDFtOpJIf/pKwwJLg==", null, false, "bb06d4d8-c79a-4e2b-a75c-3a0d270c171e", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d8949af0-a173-4241-9706-e3bf205b5817", "0ccf2492-b644-43c5-93ec-637d63b98ca0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d8949af0-a173-4241-9706-e3bf205b5817", "0ccf2492-b644-43c5-93ec-637d63b98ca0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8949af0-a173-4241-9706-e3bf205b5817");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ccf2492-b644-43c5-93ec-637d63b98ca0");

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
    }
}
