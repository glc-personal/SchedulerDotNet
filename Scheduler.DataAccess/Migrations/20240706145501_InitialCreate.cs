using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Scheduler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPhoneConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoggedInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinutesWorked = table.Column<int>(type: "int", nullable: false),
                    ConsecutiveDaysWorked = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "General Manager" },
                    { 2, "Manager" },
                    { 3, "Trainer" },
                    { 4, "Shift Lead" },
                    { 5, "Team Member" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConsecutiveDaysWorked", "CreationDate", "Email", "FirstName", "IsAdmin", "IsEmailConfirmed", "IsPhoneConfirmed", "LastLoggedInDate", "LastName", "MinutesWorked", "Password", "PhoneNumber", "Status", "Title", "TitleId", "UpdateDate", "Username" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 7, 6, 10, 55, 0, 789, DateTimeKind.Local).AddTicks(4390), "sam.tumaus@gmail.com", "Sam", true, false, false, new DateTime(2024, 7, 6, 10, 55, 0, 789, DateTimeKind.Local).AddTicks(4434), "Tumaus", 0, "$2a$10$eYEGsyyqwJMy79DJ6LHkquoLrCEpDys5HOSK0Hl3wfZoQly3cg7YO", "302-507-9985", 0, "Manager", 2, new DateTime(2024, 7, 6, 10, 55, 0, 789, DateTimeKind.Local).AddTicks(4432), "default-admin" },
                    { 2, 0, new DateTime(2024, 7, 6, 10, 55, 0, 858, DateTimeKind.Local).AddTicks(8235), "dillon.sean@gmail.com", "Dillon", false, false, false, new DateTime(2024, 7, 6, 10, 55, 0, 858, DateTimeKind.Local).AddTicks(8278), "Sean", 0, "$2a$10$DShY.dFtFjum.XQftTQ3G.GMIzWcIGf8912sfDLA6aWiQPNrOCUqe", "302-627-9281", 0, "Team Member", 5, new DateTime(2024, 7, 6, 10, 55, 0, 858, DateTimeKind.Local).AddTicks(8277), "test-team-member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
