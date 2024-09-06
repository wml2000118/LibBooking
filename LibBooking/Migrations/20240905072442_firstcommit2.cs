using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class firstcommit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6b23ee3d-5ba8-4916-ae3d-c4d30b7d4894", "3e127723-a366-46a7-9852-089019c8bfcc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b23ee3d-5ba8-4916-ae3d-c4d30b7d4894");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e127723-a366-46a7-9852-089019c8bfcc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3953ef26-ff68-46b3-9b04-c063ad049d9e", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "65a06ac9-09f7-465d-887e-58c2b95a3312", 0, "6c7a4581-0206-4c9a-9da5-60b78afe643e", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAENrv/8g/jlTMYeVizi2rkkiTvamsA12397JyJNgCSoNAtnfrzP16xutMNETwfcX4yQ==", null, false, "fc29fc37-6d38-493a-8d3b-67f24367665c", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3953ef26-ff68-46b3-9b04-c063ad049d9e", "65a06ac9-09f7-465d-887e-58c2b95a3312" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3953ef26-ff68-46b3-9b04-c063ad049d9e", "65a06ac9-09f7-465d-887e-58c2b95a3312" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3953ef26-ff68-46b3-9b04-c063ad049d9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65a06ac9-09f7-465d-887e-58c2b95a3312");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b23ee3d-5ba8-4916-ae3d-c4d30b7d4894", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3e127723-a366-46a7-9852-089019c8bfcc", 0, "759713fd-7433-44f6-b633-d7158f72f8bb", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEK0hku2JjyKnUn6TBlChKVUMMotv2jh4d1RVJiFV1yDzzn/OlS/LtWsjDiVDorGQvQ==", null, false, "42a54884-fdee-4d60-8c1b-5a530b5b470b", false, "admin@library.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6b23ee3d-5ba8-4916-ae3d-c4d30b7d4894", "3e127723-a366-46a7-9852-089019c8bfcc" });
        }
    }
}
