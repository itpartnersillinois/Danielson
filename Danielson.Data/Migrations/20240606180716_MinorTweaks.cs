using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Danielson.Data.Migrations
{
    /// <inheritdoc />
    public partial class MinorTweaks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentId",
                schema: "danielson",
                table: "User",
                newName: "StudentEvaluationId");

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEvaluated", "DateSubmitted", "LastUpdated" },
                values: new object[] { new DateTime(2024, 6, 6, 13, 7, 15, 953, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 6, 6, 13, 7, 15, 953, DateTimeKind.Local).AddTicks(5678), new DateTime(2024, 6, 6, 13, 7, 15, 953, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -4,
                column: "LastUpdated",
                value: new DateTime(2024, 6, 6, 13, 7, 15, 953, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -3,
                column: "LastUpdated",
                value: new DateTime(2024, 6, 6, 13, 7, 15, 953, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -2,
                column: "LastUpdated",
                value: new DateTime(2024, 6, 6, 13, 7, 15, 953, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -1,
                column: "LastUpdated",
                value: new DateTime(2024, 6, 6, 13, 7, 15, 953, DateTimeKind.Local).AddTicks(5520));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentEvaluationId",
                schema: "danielson",
                table: "User",
                newName: "StudentId");

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEvaluated", "DateSubmitted", "LastUpdated" },
                values: new object[] { new DateTime(2024, 5, 22, 8, 3, 18, 107, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 5, 22, 8, 3, 18, 107, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 5, 22, 8, 3, 18, 107, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -4,
                column: "LastUpdated",
                value: new DateTime(2024, 5, 22, 8, 3, 18, 107, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -3,
                column: "LastUpdated",
                value: new DateTime(2024, 5, 22, 8, 3, 18, 107, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -2,
                column: "LastUpdated",
                value: new DateTime(2024, 5, 22, 8, 3, 18, 107, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                schema: "danielson",
                table: "User",
                keyColumn: "Id",
                keyValue: -1,
                column: "LastUpdated",
                value: new DateTime(2024, 5, 22, 8, 3, 18, 107, DateTimeKind.Local).AddTicks(3458));
        }
    }
}
