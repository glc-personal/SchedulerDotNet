using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Scheduler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTestUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 27, 5, 460, DateTimeKind.Local).AddTicks(6414), new DateTime(2024, 7, 9, 16, 27, 5, 460, DateTimeKind.Local).AddTicks(6462), "$2a$10$3SMLe6R3LR6UYshRyaZRju/Cql/SysLN6mHfV11BVkXpIHSeUrfDG", new DateTime(2024, 7, 9, 16, 27, 5, 460, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 27, 5, 507, DateTimeKind.Local).AddTicks(2791), new DateTime(2024, 7, 9, 16, 27, 5, 507, DateTimeKind.Local).AddTicks(2841), "$2a$10$Qo8yCdmvbstD1LlvknaIi.MM2kNcONJND0WajXsLyXNfORplGbbIS", new DateTime(2024, 7, 9, 16, 27, 5, 507, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConsecutiveDaysWorked", "CreationDate", "Email", "FirstName", "IsAdmin", "IsEmailConfirmed", "IsPhoneConfirmed", "LastLoggedInDate", "LastName", "MinutesWorked", "Password", "PhoneNumber", "ProfilePicturePath", "Status", "Title", "TitleId", "UpdateDate", "Username" },
                values: new object[,]
                {
                    { 3, 0, new DateTime(2024, 7, 9, 16, 27, 5, 554, DateTimeKind.Local).AddTicks(4424), "kelly.green@gmail.com", "Kelly", false, false, false, new DateTime(2024, 7, 9, 16, 27, 5, 554, DateTimeKind.Local).AddTicks(4472), "Green", 0, "$2a$10$9huI47CwYt5D13O91zMqR.H2HJ30wYA7GMnyv0iMgMA2fcBdhwGZ.", "717-090-4487", "", 0, "Team Member", 5, new DateTime(2024, 7, 9, 16, 27, 5, 554, DateTimeKind.Local).AddTicks(4470), "user3-test-team-member" },
                    { 4, 0, new DateTime(2024, 7, 9, 16, 27, 5, 601, DateTimeKind.Local).AddTicks(2482), "tom.luc@gmail.com", "Tom", false, false, false, new DateTime(2024, 7, 9, 16, 27, 5, 601, DateTimeKind.Local).AddTicks(2538), "Luc", 0, "$2a$10$V0Cb963/8yZH88AjVZbKL.96/mDX0xdTP8ZTD7QvPuL8XP1k40GVG", "201-180-4464", "", 0, "Team Member", 5, new DateTime(2024, 7, 9, 16, 27, 5, 601, DateTimeKind.Local).AddTicks(2527), "user4-test-team-member" },
                    { 5, 0, new DateTime(2024, 7, 9, 16, 27, 5, 650, DateTimeKind.Local).AddTicks(4487), "gabby.ballio@gmail.com", "Gabby", false, false, false, new DateTime(2024, 7, 9, 16, 27, 5, 650, DateTimeKind.Local).AddTicks(4538), "Ballio", 0, "$2a$10$Aw3H5c6dtCW24T9CTYK11.QkjZN5hzg.tfYzZz0VIChwd/FY8bNbu", "132-343-5542", "", 0, "Team Member", 5, new DateTime(2024, 7, 9, 16, 27, 5, 650, DateTimeKind.Local).AddTicks(4536), "user5-test-team-member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 7, 9, 39, 0, 686, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 7, 7, 9, 39, 0, 686, DateTimeKind.Local).AddTicks(2476), "$2a$10$Bv8eNlYXHJ7YM9yyTkPhXufE2z7WzIpnajw8phdrgZ8uMEEBOBG0y", new DateTime(2024, 7, 7, 9, 39, 0, 686, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 7, 9, 39, 0, 754, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 7, 9, 39, 0, 754, DateTimeKind.Local).AddTicks(980), "$2a$10$f63xR4I2xtYeTtSXy.1ax.GXuAvcdznatIgymEzcgaXxaOuuKzajK", new DateTime(2024, 7, 7, 9, 39, 0, 754, DateTimeKind.Local).AddTicks(978) });
        }
    }
}
