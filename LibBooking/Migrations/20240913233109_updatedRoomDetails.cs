using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibBooking.Migrations
{
    /// <inheritdoc />
    public partial class updatedRoomDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3953ef26-ff68-46b3-9b04-c063ad049d9e", "65a06ac9-09f7-465d-887e-58c2b95a3312" });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3953ef26-ff68-46b3-9b04-c063ad049d9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65a06ac9-09f7-465d-887e-58c2b95a3312");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Rooms",
                newName: "Facilities");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac74f3f3-822a-4d55-a11c-41b7d245fd1a", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d", 0, "7e7d94ae-f88b-4d91-a98c-0b87eb393cd9", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAEP1a7TvQD2BsaxoCjZ0wwOctzIQvFJBK0+Mh00zGyf/xKKDI6IfchSRWZFea/gCltg==", null, false, "73faa417-f7fc-40d7-b2a1-25feae11a316", false, "admin@library.com" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Capacity", "Facilities", "RoomName" },
                values: new object[] { 5, "wifi, power, whiteboard, 5 computers, projector", "Meeting room 2 - glass slided" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Capacity", "Facilities", "RoomName" },
                values: new object[] { 16, "wifi, power, whiteboard, 16 computers, projector", "Meeting Room 3" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Capacity", "Facilities", "RoomName" },
                values: new object[] { 2, "wifi, power, whiteboard, 2 computers", "Meeting Room 5, Student Connection Room" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ac74f3f3-822a-4d55-a11c-41b7d245fd1a", "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac74f3f3-822a-4d55-a11c-41b7d245fd1a", "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac74f3f3-822a-4d55-a11c-41b7d245fd1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5fd35fb-1cb0-47ed-b7b4-29e713dec55d");

            migrationBuilder.RenameColumn(
                name: "Facilities",
                table: "Rooms",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3953ef26-ff68-46b3-9b04-c063ad049d9e", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "65a06ac9-09f7-465d-887e-58c2b95a3312", 0, "6c7a4581-0206-4c9a-9da5-60b78afe643e", "admin@library.com", true, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAIAAYagAAAAENrv/8g/jlTMYeVizi2rkkiTvamsA12397JyJNgCSoNAtnfrzP16xutMNETwfcX4yQ==", null, false, "fc29fc37-6d38-493a-8d3b-67f24367665c", false, "admin@library.com" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "RoomName" },
                values: new object[] { 10, "Description for Room A", "Room A" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "RoomName" },
                values: new object[] { 20, "Description for Room B", "Room B" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "RoomName" },
                values: new object[] { 30, "Description for Room C", "Room C" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Capacity", "Description", "RoomName" },
                values: new object[] { 4, 40, "Description for Room D", "Room D" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3953ef26-ff68-46b3-9b04-c063ad049d9e", "65a06ac9-09f7-465d-887e-58c2b95a3312" });
        }
    }
}
