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
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalScore = table.Column<double>(type: "float", nullable: false),
                    FinalSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMidterm = table.Column<bool>(type: "bit", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    SemesterDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Domain",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domain_Form_FormId",
                        column: x => x.FormId,
                        principalSchema: "danielson",
                        principalTable: "Form",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DomainTemplate",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    FormTemplateId = table.Column<int>(type: "int", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DomainTemplate_FormTemplate_FormTemplateId",
                        column: x => x.FormTemplateId,
                        principalSchema: "danielson",
                        principalTable: "FormTemplate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DomainTemplate_Form_FormId",
                        column: x => x.FormId,
                        principalSchema: "danielson",
                        principalTable: "Form",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ComponentTemplate",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentConsiderations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComponentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainTemplateId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SectionTemplateId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentTemplate_DomainTemplate_DomainTemplateId",
                        column: x => x.DomainTemplateId,
                        principalSchema: "danielson",
                        principalTable: "DomainTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentAnswer",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentConsiderations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComponentTemplateId = table.Column<int>(type: "int", nullable: false),
                    ComponentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    IsNotObserved = table.Column<bool>(type: "bit", nullable: false),
                    NextSteps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    QualitativeScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantitativeScore = table.Column<int>(type: "int", nullable: false),
                    Strengths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentAnswer_ComponentTemplate_ComponentTemplateId",
                        column: x => x.ComponentTemplateId,
                        principalSchema: "danielson",
                        principalTable: "ComponentTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentAnswer_Domain_DomainId",
                        column: x => x.DomainId,
                        principalSchema: "danielson",
                        principalTable: "Domain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentOptionTemplate",
                schema: "danielson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CombineWithPrevious = table.Column<bool>(type: "bit", nullable: false),
                    ComponentTemplateId = table.Column<int>(type: "int", nullable: true),
                    OptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QualitativeScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantitativeScore = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentOptionTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentOptionTemplate_ComponentTemplate_ComponentTemplateId",
                        column: x => x.ComponentTemplateId,
                        principalSchema: "danielson",
                        principalTable: "ComponentTemplate",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "danielson",
                table: "DomainTemplate",
                columns: new[] { "Id", "DomainDescription", "DomainTitle", "DomainType", "FormId", "FormTemplateId", "IsActive", "IsDefault", "LastUpdated" },
                values: new object[,]
                {
                    { -4, "", "Default 4", 3, null, null, true, true, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(601) },
                    { -3, "", "Default 3", 2, null, null, true, true, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(593) },
                    { -2, "", "Default 2", 1, null, null, true, true, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(581) },
                    { -1, "", "Default 1", 0, null, null, true, true, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(432) }
                });

            migrationBuilder.InsertData(
                schema: "danielson",
                table: "User",
                columns: new[] { "Id", "Email", "Guid", "IsActive", "LastUpdated", "Role", "StudentId", "Username" },
                values: new object[,]
                {
                    { -4, "cotestaff@illinois.edu", new Guid("b1dfc3d3-b726-4946-a65f-9489d360662f"), false, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(1198), 4, 0, "cotestaff" },
                    { -3, "supervisor@illinois.edu", new Guid("50924bd6-1494-4c5c-a064-81b8aabedfa2"), false, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(1167), 2, 0, "supervisor" },
                    { -2, "student@illinois.edu", new Guid("3784cb3c-681f-45b0-9b67-391ca17f5c0f"), false, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(1150), 1, 0, "student" },
                    { -1, "admin@illinois.edu", new Guid("be31303e-404a-471c-b7c0-dfdea01a4121"), false, new DateTime(2024, 5, 10, 16, 41, 3, 780, DateTimeKind.Local).AddTicks(1063), 99, 0, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentAnswer_ComponentTemplateId",
                schema: "danielson",
                table: "ComponentAnswer",
                column: "ComponentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentAnswer_DomainId",
                schema: "danielson",
                table: "ComponentAnswer",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentOptionTemplate_ComponentTemplateId",
                schema: "danielson",
                table: "ComponentOptionTemplate",
                column: "ComponentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTemplate_DomainTemplateId",
                schema: "danielson",
                table: "ComponentTemplate",
                column: "DomainTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Domain_FormId",
                schema: "danielson",
                table: "Domain",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainTemplate_FormId",
                schema: "danielson",
                table: "DomainTemplate",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainTemplate_FormTemplateId",
                schema: "danielson",
                table: "DomainTemplate",
                column: "FormTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentAnswer",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "ComponentOptionTemplate",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "User",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "Domain",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "ComponentTemplate",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "DomainTemplate",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "FormTemplate",
                schema: "danielson");

            migrationBuilder.DropTable(
                name: "Form",
                schema: "danielson");
        }
    }
}
