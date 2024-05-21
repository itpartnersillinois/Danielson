using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Danielson.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "danielson");

            migrationBuilder.CreateTable(
                name: "Form",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    DateEvaluated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalScore = table.Column<double>(type: "float", nullable: false),
                    FinalScoreText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormTemplateInternalLookupString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMidterm = table.Column<bool>(type: "bit", nullable: false),
                    PlacementType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    SemesterDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowNotObserved = table.Column<bool>(type: "bit", nullable: false),
                    ShowQuantitativeAnswer = table.Column<bool>(type: "bit", nullable: false),
                    Student = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentEvaluationId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormTemplate",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinalAnswerOptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalLookupString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComponentAnswer",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentConsiderations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComponentOrder = table.Column<int>(type: "int", nullable: false),
                    ComponentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DomainItem = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    QualitativeScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantitativeScore = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentAnswer_Form_FormId",
                        column: x => x.FormId,
                        principalSchema: "danielson",
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsiderationTemplate",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentOrder = table.Column<int>(type: "int", nullable: false),
                    ConsiderationText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainItem = table.Column<int>(type: "int", nullable: false),
                    FormTemplateId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsiderationTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsiderationTemplate_FormTemplate_FormTemplateId",
                        column: x => x.FormTemplateId,
                        principalSchema: "danielson",
                        principalTable: "FormTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "danielson",
                table: "User",
                columns: new[] { "Id", "Email", "Guid", "IsActive", "LastUpdated", "Role", "StudentId", "Username" },
                values: new object[,]
                {
                    { -4, "cotestaff@illinois.edu", new Guid("b1dfc3d3-b726-4946-a65f-9489d360662f"), false, new DateTime(2024, 5, 21, 17, 33, 53, 689, DateTimeKind.Local).AddTicks(6866), 4, 0, "cotestaff" },
                    { -3, "supervisor@illinois.edu", new Guid("50924bd6-1494-4c5c-a064-81b8aabedfa2"), false, new DateTime(2024, 5, 21, 17, 33, 53, 689, DateTimeKind.Local).AddTicks(6861), 2, 0, "supervisor" },
                    { -2, "student@illinois.edu", new Guid("3784cb3c-681f-45b0-9b67-391ca17f5c0f"), false, new DateTime(2024, 5, 21, 17, 33, 53, 689, DateTimeKind.Local).AddTicks(6855), 1, 0, "student" },
                    { -1, "admin@illinois.edu", new Guid("be31303e-404a-471c-b7c0-dfdea01a4121"), false, new DateTime(2024, 5, 21, 17, 33, 53, 689, DateTimeKind.Local).AddTicks(6844), 99, 0, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentAnswer_FormId",
                schema: "danielson",
                table: "ComponentAnswer",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsiderationTemplate_FormTemplateId",
                schema: "danielson",
                table: "ConsiderationTemplate",
                column: "FormTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentAnswer",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "ConsiderationTemplate",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "User",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "Form",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "FormTemplate",
                schema: "danielson");
        }
    }
}
