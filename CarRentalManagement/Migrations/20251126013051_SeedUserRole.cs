using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5b79f90b-cd07-4541-b2ff-13b1aa24e53b", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIP/sFCjC5c/zqhhgR+HDHr54kdcPHE970PKt04fhBm5el7pjKOLBcDDxjaWt2eJwQ==", null, false, "f672e323-cdec-4188-aaaa-ef17b77cfa5a", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8495), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8512), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8752), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8755), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8966), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8971), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8974), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 11, 26, 9, 30, 49, 590, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(5870), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(5893), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6151), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6154), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6255), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6261), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6264), new DateTime(2025, 11, 24, 16, 38, 10, 329, DateTimeKind.Local).AddTicks(6265) });
        }
    }
}
