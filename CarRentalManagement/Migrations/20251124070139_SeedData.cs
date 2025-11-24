using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5150), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5161), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5164), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5164), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5373), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5374), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5376), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5377), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5448), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5449), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5451), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5452), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5453), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5454), new DateTime(2025, 11, 24, 15, 1, 38, 361, DateTimeKind.Local).AddTicks(5455), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
