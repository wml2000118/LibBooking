using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class updatedLibraryViewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "918429d0-15ea-4637-b28b-2a59a992fd64", "df380cff-abd7-4380-9395-29ab0fc2649e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "918429d0-15ea-4637-b28b-2a59a992fd64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df380cff-abd7-4380-9395-29ab0fc2649e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97688feb-9e4f-4962-83cf-dcaa9bb087fe", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6fb284e0-91ae-457c-aedc-ec0742c3d421", 0, "115037b2-a9e5-44a7-8150-2f6d71b2e155", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEL32Y1EqgaMmaJDICu6vLpoYiuYCrGRhQGI6NTW0SxlfKI2nL8B5Hb095XX0Vpv6kQ==", null, false, "96bd421e-1b55-47d1-b18b-f17ef4987ad8", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "97688feb-9e4f-4962-83cf-dcaa9bb087fe", "6fb284e0-91ae-457c-aedc-ec0742c3d421" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97688feb-9e4f-4962-83cf-dcaa9bb087fe", "6fb284e0-91ae-457c-aedc-ec0742c3d421" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97688feb-9e4f-4962-83cf-dcaa9bb087fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fb284e0-91ae-457c-aedc-ec0742c3d421");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "918429d0-15ea-4637-b28b-2a59a992fd64", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df380cff-abd7-4380-9395-29ab0fc2649e", 0, "7be84570-2b5c-4039-ad77-a0d9cb7776c4", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEBly2PPjCarPCCgQC/bGG7v2euC/mqSxKc4pvkz2W5CUp/QrJ/XYN4sgj5L+/semRA==", null, false, "cb7d83c4-b3d3-4be3-97ac-3bc4cbedc17e", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "918429d0-15ea-4637-b28b-2a59a992fd64", "df380cff-abd7-4380-9395-29ab0fc2649e" });
        }
    }
}
