using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class updatedSubjectGuides : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f706edd6-532a-47b2-a2b5-df0ad1b00c2d", "f4bc5d8e-cc7b-4ddc-8ac6-7c57c614cc41" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f706edd6-532a-47b2-a2b5-df0ad1b00c2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4bc5d8e-cc7b-4ddc-8ac6-7c57c614cc41");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "918429d0-15ea-4637-b28b-2a59a992fd64", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df380cff-abd7-4380-9395-29ab0fc2649e", 0, "7be84570-2b5c-4039-ad77-a0d9cb7776c4", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEBly2PPjCarPCCgQC/bGG7v2euC/mqSxKc4pvkz2W5CUp/QrJ/XYN4sgj5L+/semRA==", null, false, "cb7d83c4-b3d3-4be3-97ac-3bc4cbedc17e", false, "admin@library.com" });

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 1,
                column: "SubjectGuidesUrl",
                value: "https://whitireia.libguides.com/prf.php?id=c998c597-7bd7-11ed-9738-0ae0bf56cf20");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 2,
                column: "SubjectGuidesUrl",
                value: "https://whitireia.libguides.com/prf.php?id=c9a972af-7bd7-11ed-9738-0ae0bf56cf20");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 3,
                column: "SubjectGuidesUrl",
                value: "https://whitireia.libguides.com/prf.php?id=c9a970c8-7bd7-11ed-9738-0ae0bf56cf20");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "918429d0-15ea-4637-b28b-2a59a992fd64", "df380cff-abd7-4380-9395-29ab0fc2649e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f706edd6-532a-47b2-a2b5-df0ad1b00c2d", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f4bc5d8e-cc7b-4ddc-8ac6-7c57c614cc41", 0, "5cae9b5b-f359-477b-b74f-15ae6e423caa", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEPcNb+fqqffgOyIC/LC/bF20O5jSpNzsdrGPr6M2q/erWs4ZugBja+mMqGg1Bbzw4g==", null, false, "688172b4-b894-4393-b964-d47c01af36ab", false, "admin@library.com" });

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 1,
                column: "SubjectGuidesUrl",
                value: "#");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 2,
                column: "SubjectGuidesUrl",
                value: "#");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 3,
                column: "SubjectGuidesUrl",
                value: "#");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f706edd6-532a-47b2-a2b5-df0ad1b00c2d", "f4bc5d8e-cc7b-4ddc-8ac6-7c57c614cc41" });
        }
    }
}
