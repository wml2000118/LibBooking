using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class Frstcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
