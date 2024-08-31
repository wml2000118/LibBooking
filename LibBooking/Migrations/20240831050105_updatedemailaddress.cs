using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class updatedemailaddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c", "4c31d7e7-7de8-454d-90d5-70ba1b4c070d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c31d7e7-7de8-454d-90d5-70ba1b4c070d");

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
                column: "Email",
                value: "judith.hall@wandw.ac.nz");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 2,
                column: "Email",
                value: "sarah.knox@wandw.ac.nz");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 3,
                column: "Email",
                value: "madeleine.bowles@wandw.ac.nz");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f706edd6-532a-47b2-a2b5-df0ad1b00c2d", "f4bc5d8e-cc7b-4ddc-8ac6-7c57c614cc41" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4c31d7e7-7de8-454d-90d5-70ba1b4c070d", 0, "c3a63220-cf9a-48e8-ad05-3e8263082c33", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEMKbBqftJhM2mR8VX+UPswz7al1DwwMCEEwHXaXF7A3/Ekfww6TH931I9Aet+mvrow==", null, false, "cd2de34f-176a-4e2e-ac41-09ef9056decf", false, "admin@library.com" });

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 1,
                column: "Email",
                value: "judith@library.com");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 2,
                column: "Email",
                value: "sarah@library.com");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 3,
                column: "Email",
                value: "maddie@library.com");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc102cb9-d9bd-45b8-a22e-50b07e62ca6c", "4c31d7e7-7de8-454d-90d5-70ba1b4c070d" });
        }
    }
}
