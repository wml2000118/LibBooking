using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class revertEmailModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "93566724-b788-4e44-ae64-66dbdfc19fc4", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8c2fe47d-aea4-4bf1-ad45-52114c461c7a", 0, "74b58a36-cfc2-48a9-8624-52f0f64e271d", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEG42BDIFAmj8dKXIlCxhI9xHhf7QNieYJAK/JjEgtzQM6fcNTGDZmIFCJW95/KAwow==", null, false, "961070f3-a444-426e-8169-96e3ea6fe437", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "93566724-b788-4e44-ae64-66dbdfc19fc4", "8c2fe47d-aea4-4bf1-ad45-52114c461c7a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93566724-b788-4e44-ae64-66dbdfc19fc4", "8c2fe47d-aea4-4bf1-ad45-52114c461c7a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93566724-b788-4e44-ae64-66dbdfc19fc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c2fe47d-aea4-4bf1-ad45-52114c461c7a");

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
    }
}
