using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scheduler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfilePicturePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicturePath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "ProfilePicturePath", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 7, 9, 39, 0, 686, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 7, 7, 9, 39, 0, 686, DateTimeKind.Local).AddTicks(2476), "$2a$10$Bv8eNlYXHJ7YM9yyTkPhXufE2z7WzIpnajw8phdrgZ8uMEEBOBG0y", "", new DateTime(2024, 7, 7, 9, 39, 0, 686, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "ProfilePicturePath", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 7, 9, 39, 0, 754, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 7, 9, 39, 0, 754, DateTimeKind.Local).AddTicks(980), "$2a$10$f63xR4I2xtYeTtSXy.1ax.GXuAvcdznatIgymEzcgaXxaOuuKzajK", "", new DateTime(2024, 7, 7, 9, 39, 0, 754, DateTimeKind.Local).AddTicks(978) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicturePath",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 6, 10, 55, 0, 789, DateTimeKind.Local).AddTicks(4390), new DateTime(2024, 7, 6, 10, 55, 0, 789, DateTimeKind.Local).AddTicks(4434), "$2a$10$eYEGsyyqwJMy79DJ6LHkquoLrCEpDys5HOSK0Hl3wfZoQly3cg7YO", new DateTime(2024, 7, 6, 10, 55, 0, 789, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "LastLoggedInDate", "Password", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 6, 10, 55, 0, 858, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 7, 6, 10, 55, 0, 858, DateTimeKind.Local).AddTicks(8278), "$2a$10$DShY.dFtFjum.XQftTQ3G.GMIzWcIGf8912sfDLA6aWiQPNrOCUqe", new DateTime(2024, 7, 6, 10, 55, 0, 858, DateTimeKind.Local).AddTicks(8277) });
        }
    }
}
